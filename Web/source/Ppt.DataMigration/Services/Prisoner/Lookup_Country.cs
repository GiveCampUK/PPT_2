using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using Ppt.DataMigration.Services.Friends;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Country : Country
    {        
        public Lookup_Country()
        {
            AccessTableName = "Lookup_Country";
            NewTableName = "Country";
        }

        public override void MigrateTable()
        {
            try
            {
                SQLConnection.Open();
                AccessConnection.Open();

                var oleCmd = GetSelectAllCommand();
                var adapter = GetSqlAdapter();
                var dataSet = GetAndFillDataSet(adapter);
                var dt = GetDataTable(dataSet);

                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    var results = dt.Select("Name = '{0}'".Formatted(reader["COUNTRY"].ToString().Replace("'", "''")));
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
