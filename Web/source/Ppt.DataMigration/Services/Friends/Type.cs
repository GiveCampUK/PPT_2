using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class TypeImport : AbstractTableMigrationService
    {

        public TypeImport()
        {
            AccessTableName = "Type";
            NewTableName = "PersonType";
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
                    currentIdentifier = reader["CODE"].ToString();

                    var results = dt.Select("ShortCode = '{0}'".Formatted(reader["CODE"].ToString().Replace("'", "''")));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Name"] = reader["DESC"];
                        newRow["ShortCode"] = reader["CODE"];
                        dt.Rows.Add(newRow);
                    }
                }

                reader.Close();
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                this.Logger.Error(DataImportErrorFormatter.FormatErrorMessage(this.AccessConnection.Database, this.AccessTableName, this.NewTableName, "", ex.Message));
            }
            finally
            {
                AccessConnection.Close();
                SQLConnection.Close();//should we open and close for each database?
            }
        }
    }
}
