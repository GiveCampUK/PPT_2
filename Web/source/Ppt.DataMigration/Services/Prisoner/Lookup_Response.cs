using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Response : AbstractTableMigrationService
    {
        public Lookup_Response()
        {
            AccessTableName = "LOOKUP_RESPONSE";
            NewTableName = "ResponseType";
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
                    currentIdentifier = reader["RESPONSE"].ToString();

                    var results = dt.Select("RESPONSE = '{0}'".Formatted(reader["RESPONSE"].ToString().Replace("'", "''")));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["RESPONSE"] = reader["RESPONSE"];
                        dt.Rows.Add(newRow);
                        adapter.Update(dt);
                    }
                }

                reader.Close();
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
