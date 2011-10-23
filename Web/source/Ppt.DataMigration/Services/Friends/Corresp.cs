using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Corresp : AbstractTableMigrationService
    {
        public Corresp()
        {
            AccessTableName = "CORRESP";
            NewTableName = "Corresp";
        }

        public override void MigrateTable()
        {
            string currentIdentifier = string.Empty;

            try
            {
                SQLConnection.Open();
                AccessConnection.Open();

                //Get Access Data
                var oleCmd = GetSelectAllCommand();
                var adapter = GetSqlAdapter();
                var dataSet = GetAndFillDataSet(adapter);
                var dt = GetDataTable(dataSet);

                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    currentIdentifier = reader["Corref"].ToString();

                    var results = dt.Select("Corref = '{0}'".Formatted(reader["Corref"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Corref"] = reader["CORREF"];
                        newRow["Refno"] = reader["REFNO"];
                        newRow["Date1"] = reader["DATE"];
                        newRow["Type"] = reader["TYPE"];
                        newRow["Filing"] = reader["FILING"];
                        newRow["Response"] = GetResponseTypeSql(reader["RESPONSE"] as string);
                        newRow["Destination"] = reader["DESTINATION"];
                        newRow["Correspondant"] = reader["CORRESPONDENT"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                this.Logger.Error(DataImportErrorFormatter.FormatErrorMessage(this.AccessConnection.DataSource, this.AccessTableName, this.NewTableName, currentIdentifier, ex.Message));
            }
            finally
            {
                AccessConnection.Close();
                SQLConnection.Close();//should we open and close for each database?
            }
        }
    }
}
