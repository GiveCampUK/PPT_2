using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Country : AbstractTableMigrationService
    {
        public Country()
        {
            AccessTableName = "COUNTRY";
            NewTableName = "Country";
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
                    var results = dt.Select("Name = '{0}'".Formatted(reader["COUNTRY"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Name"] = reader["COUNTRY"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                AccessConnection.Close();
                SQLConnection.Close();//should we open and close for each database?
            }
        }
    }
}
