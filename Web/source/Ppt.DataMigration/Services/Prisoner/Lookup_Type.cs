using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Type : AbstractTableMigrationService
    {
        
        public Lookup_Type()
        {
            AccessTableName = "Lookup_Type";
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

                OleDbCommand oleCmd = AccessConnection.CreateCommand();
                oleCmd.CommandText = "SELECT * FROM " + AccessTableName;

                //get current records in SQL
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM COUNTRY", SQLConnection);

                DataSet sqlCountry = new DataSet("Country");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "COUNTRY");
                sqlAdapter.Fill(sqlCountry);
                DataTable dt = sqlCountry.Tables["COUNTRY"];

                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    currentIdentifier = reader["COUNTRY"].ToString();

                    var results = dt.Select("Name = '{0}'".Formatted(reader["COUNTRY"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Name"] = reader["COUNTRY"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                dt.AcceptChanges();
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
