using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Gifts : AbstractTableMigrationService
    {
        public Gifts()
        {
            AccessTableName = "Gifts";
            NewTableName = "Gifts";
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
                    currentIdentifier = reader["REFNO"].ToString();

                    var results = dt.Select("Id = '{0}'".Formatted(reader["REFNO"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Id"] = reader["REFNO"];
                        newRow["Date"] = reader["DATE"];
                        newRow["GiftType"] = GetResponseTypeSql(reader["GTYPE"] as string);
                        newRow["Amount"] = reader["AMOUNT"];
                        newRow["Source"] = reader["SOURCE"];
                        newRow["Purpose"] = reader["PURPOSE"];
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
