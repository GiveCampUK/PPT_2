using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Type : AbstractTableMigrationService
    {
        public Type()
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
                    var results = dt.Select("ShortCode = '{0}'".Formatted(reader["CODE"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["ShortCode"] = reader["CODE"];
                        newRow["Name"] = reader["DESC"];
                        dt.Rows.Add(newRow);
                        adapter.Update(dt);
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                this.Logger.Error(DataImportErrorFormatter.FormatErrorMessage(this.AccessConnection.DataSource,
                                                                              this.AccessTableName, this.NewTableName,
                                                                              currentIdentifier, ex.Message));
            }
            finally
            {
                AccessConnection.Close();
                SQLConnection.Close(); //should we open and close for each database?
            }
        }
    }
}
