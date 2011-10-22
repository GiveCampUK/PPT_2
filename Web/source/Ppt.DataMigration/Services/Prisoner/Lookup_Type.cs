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
             public string AccessTableName { get; set; }

             public Lookup_Type()
        {
            AccessTableName= "Lookup_Type";
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
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM PersonType", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("PersonType");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "PersonType");
                sqlAdapter.Fill(sqlCountry);
                DataTable dt = sqlCountry.Tables["PersonType"];


                
                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    var results = dt.Select("Name = '{0}'".Formatted(reader["CODE"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Name"] = reader["DESC"];
                        newRow["ShortCode"] = reader["CODE"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                sqlAdapter.Update(dt);
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
