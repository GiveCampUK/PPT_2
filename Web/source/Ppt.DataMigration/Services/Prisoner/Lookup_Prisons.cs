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
        public Lookup_Prisons()
        {
            AccessTableName= "Lookup_Prisons";
            NewTableName = "Prison";
        }

        public override void MigrateTable()
        {
            string currentIdentifier = string.Empty;

            try
            {
                SQLConnection.Open();
                AccessConnection.Open();
                
                //turn of ID column OFF

                SqlCommand identOff = new SqlCommand("SET IDENTITY_INSERT " + NewTableName + " OFF", SQLConnection);
                identOff.ExecuteScalar();

                var oleCmd = GetSelectAllCommand();
                var adapter = GetSqlAdapter();
                var dataSet = GetAndFillDataSet(adapter);
                var dt = GetDataTable(dataSet);
                
                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    currentIdentifier = reader["Prison"].ToString();

                    var results = dt.Select("Name = '{0}'".Formatted(reader.Cleaned("Prison")));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Id"] = reader.Cleaned("PRISON ID");
                        newRow["Name"] = reader.Cleaned("PRISON");
                        newRow["MailName"] = reader.Cleaned("MailName");
                        newRow["Address1"] = reader.Cleaned("Add1");
                        newRow["Address2"] = reader.Cleaned("Add2");
                        newRow["Address3"] = reader.Cleaned("Add3");
                        newRow["Town"] = reader.Cleaned("Town");
                        newRow["County"] = reader.Cleaned("County");
                        newRow["Postcode"] = reader.Cleaned("Postcode");
                        newRow["Country"] = GetCountryFromSql(reader.Cleaned("Country"));
                        newRow["Sex"] = GetPrisonSexFromSql(reader.Cleaned("M/F"));
                        newRow["MalePrisonersHeld"] = reader.Cleaned("MalePrisonersHeld").AsBool();
                        newRow["FemalePrisonersHeld"] = reader.Cleaned("FemalePrisonersHeld").AsBool();
                        newRow["YoungOffendersHeld"] = reader.Cleaned("YoungOffendersHeld").AsBool();
                        newRow["JuvenilePrisonersHeld"] = reader.Cleaned("JuvenilePrisonersHeld").AsBool();
                        newRow["AdultPrisonersHeld"] = reader.Cleaned("AdultPrisonersHeld").AsBool();
                        newRow["Cat"] = reader.Cleaned("Cat");
                        newRow["Ptype"] = reader.Cleaned("Ptype");
                        newRow["VolunteersNotes"] = reader.Cleaned("Volunteers Notes");
                        newRow["Notes"] = reader.Cleaned("Notes");
                        newRow["Governor"] = reader.Cleaned("Governor");
                        newRow["Telephone"] = reader.Cleaned("Telephone");
                        newRow["Tag"] = reader.Cleaned("Tag");
                        newRow["NlAddressOrder"] = reader["Nl Address Order"];
                        newRow["InclInNlAddressList"] = reader.Cleaned("Incl In Nl Address List").AsBool();
                        newRow["DesignationNewsletter"] = reader.Cleaned("Designation Newsletter");
                        newRow["Location"] = reader.Cleaned("Location");
                        newRow["ContactForNewsletter"] = reader.Cleaned("ContactForNewsletter");
                        newRow["ContactPosition"] = reader.Cleaned("ContactPosition");
                        newRow["ContactPhone"] = reader.Cleaned("ContactPhone");
                        newRow["ContactFax"] = reader.Cleaned("ContactFax");
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                adapter.Update(dt);


                 //turn of ID column ON

                SqlCommand identOn = new SqlCommand("SET IDENTITY_INSERT " + NewTableName + " ON", SQLConnection);
                identOn.ExecuteScalar();
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
