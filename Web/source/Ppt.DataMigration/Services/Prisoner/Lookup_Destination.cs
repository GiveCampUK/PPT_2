using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Destination : AbstractTableMigrationService
    {
       
             public string AccessTableName { get; set; }

        public Lookup_Destination()
        {
            AccessTableName= "Lookup_Destination";
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
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM DESTINATION", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("DESTINATION");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "DESTINATION");
                sqlAdapter.Fill(sqlCountry);
                DataTable dt = sqlCountry.Tables["DESTINATION"];


                
                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    var results = dt.Select("Name = '{0}'".Formatted(reader["DESTINATION"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Name"] = reader["DESTINATION"];
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
