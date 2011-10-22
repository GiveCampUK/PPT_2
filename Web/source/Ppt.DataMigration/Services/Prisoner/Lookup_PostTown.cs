﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_PostTown : AbstractTableMigrationService
    {
        public string AccessTableName { get; set; }

        public Lookup_PostTown()
        {
            AccessTableName= "LOOKUP_POSTTOWN";
        }

        public override void MigrateTable()
        {
            try
            {
                SQLConnection.Open();
                AccessConnection.Open();

                //Get Access Data
                OleDbCommand oleCmd = AccessConnection.CreateCommand();
                oleCmd.CommandText = "SELECT * FROM " + AccessTableName;

                //get current records in SQL
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Town", SQLConnection);
               
                DataSet sqlCountry = new DataSet("Town");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "Town");
                sqlAdapter.Fill(sqlCountry);
                DataTable dt = sqlCountry.Tables["Town"];

                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    var results = dt.Select("Name = '{0}'".Formatted(reader["Town"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Name"] = reader["Town"];
                        dt.Rows.Add(newRow);
                    }
                }

                reader.Close();
                dt.AcceptChanges();
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
