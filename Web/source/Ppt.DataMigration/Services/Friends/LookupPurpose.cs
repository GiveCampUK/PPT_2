using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class LookupPurpose : AbstractTableMigrationService
    {
        public LookupPurpose()
        {
            AccessTableName = "[Lookup Purpose]";
            NewTableName = "PurposeType";
        }

        public override void MigrateTable()
        {
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
                    

                    var results = dt.Select("ShortCode = '{0}'".Formatted(reader["Field1"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["ShortCode"] = reader["Field1"];
                        newRow["Name"] = reader["Field2"];
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
