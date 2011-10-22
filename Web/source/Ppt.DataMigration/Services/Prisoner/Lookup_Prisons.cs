using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Prisons : AbstractTableMigrationService
    {
       
             public string AccessTableName { get; set; }

             public Lookup_Prisons()
        {
            AccessTableName= "Lookup_Prisons";
        }
        public override void MigrateTable()
        {

            try
            {
                SQLConnection.Open();
                AccessConnection.Open();
                
                //turn of ID column OFF

                SqlCommand identOff = new SqlCommand("SET IDENTITY_INSERT Prison OFF", SQLConnection);
                identOff.ExecuteScalar();
                
                //Get Access Data

                OleDbCommand oleCmd = AccessConnection.CreateCommand();
                oleCmd.CommandText = "SELECT * FROM " + AccessTableName;


                //get current records in SQL
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM PRISON", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("Prison");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "Prison");
                sqlAdapter.Fill(sqlCountry);
                DataTable dt = sqlCountry.Tables["Prison"];


                
                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    var results = dt.Select("Name = '{0}'".Formatted(reader["Prison"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Id"] = reader["PRISON ID"];
                        newRow["Name"] = reader["PRISON"];
                        newRow["MailName"] = reader["MailName"];
                        newRow["Address1"] = reader["Add1"];
                        newRow["Address2"] = reader["Add2"];
                        newRow["Address3"] = reader["Add3"];
                        newRow["Town"] = reader["Town"];
                        newRow["County"] = reader["County"];
                        newRow["Postcode"] = reader["Postcode"];
                        newRow["Country"] = GetCountryFromSql(reader["County"] as string);
                        newRow["Sex"] = GetPrisonSexFromSql(reader["Sex"] as string);
                        newRow["MalePrisonersHeld"] = reader["MalePrisonersHeld"];
                        newRow["FemalePrisonersHeld"] = reader["FemalePrisonersHeld"];
                        newRow["JuvenilePrisonersHeld"] = reader["JuvenilePrisonersHeld"];
                        newRow["AdultPrisonersHeld"] = reader["AdultPrisonersHeld"];
                        newRow["Cat"] = reader["Cat"];
                        newRow["Ptype"] = reader["Ptype"];
                        newRow["VolunteersNotes"] = reader["Volunteers Notes"];
                        newRow["Notes"] = reader["Notes"];
                        newRow["Governor"] = reader["Governor"];
                        newRow["Telephone"] = reader["Telephone"];
                        newRow["Tag"] = reader["Tag"];
                        newRow["NlAddressOrder"] = reader["Nl Address Order"];
                        newRow["InclInNlAddressList"] = reader["Incl In Nl Address List"];
                        newRow["DesignationNewsletter"] = reader["Designation Newsletter"];
                        newRow["Location"] = reader["Location"];
                        newRow["ContactsForNewsletter"] = reader["ContactsForNewsletter"];
                        newRow["ContactPosition"] = reader["ContactPosition"];
                        newRow["ContactPhone"] = reader["ContactPhone"];
                        newRow["ContactFax"] = reader["ContactFax"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                sqlAdapter.Update(dt);


                 //turn of ID column ON

                SqlCommand identOn = new SqlCommand("SET IDENTITY_INSERT Prison ON", SQLConnection);
                identOn.ExecuteScalar();
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
