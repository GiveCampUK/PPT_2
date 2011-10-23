using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Contact : AbstractTableMigrationService
    {
        public Contact()
        {
            AccessTableName = "CONTACT";
            NewTableName = "Contacts";
        }

        public override void MigrateTable()
        {
            try
            {
                SQLConnection.Open();
                AccessConnection.Open();

                SqlCommand identOff = new SqlCommand("SET IDENTITY_INSERT " + NewTableName + " OFF", SQLConnection);
                identOff.ExecuteScalar();

                var oleCmd = GetSelectAllCommand();
                var adapter = GetSqlAdapter();
                var dataSet = GetAndFillDataSet(adapter);
                var dt = GetDataTable(dataSet);

                var reader = oleCmd.ExecuteReader();
                while (reader.Read())
                {
                    var results = dt.Select("Id = '{0}'".Formatted(reader["REFNO"].ToString().Replace("'", "''")));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Id"] = reader["REFNO"]; // primary key, int
                        newRow["Surname"] = reader["SURNAME"].ToString().Replace("'", "''");
                        newRow["Forename"] = reader["FORENAME"].ToString().Replace("'", "''");
                        newRow["Title"] = GetTitleSql(reader["TITLE"] as string).ToString().Replace("'", "''"); // foreign key, int
                        newRow["Position"] = reader["POSITION"].ToString().Replace("'", "''");
                        newRow["MailName"] = reader["MAILNAME"].ToString().Replace("'", "''");
                        newRow["Salutation"] = reader["SALUTATION"].ToString().Replace("'", "''");
                        newRow["Type"] = reader["TYPE"];
                        //newRow["EmailAddress"] = reader["EmailAddress"];
                        newRow["Source"] = reader["SOURCE"];
                        newRow["DOB"] = reader["DOB"];
                        newRow["MailCode"] = GetMailCodeSql(reader["MAILCODE"] as string).ToString().Replace("'", "''"); // foreign key
                        newRow["Lost"] = reader["LOST"]; //datetime
                        newRow["Deceased"] = reader["DECEASED"].AsBool(); //bit
                        newRow["ArchivePrisonName"] = reader["PREVPRIS1"];
                        newRow["PNumber"] = reader["PNUMBER"];
                        newRow["Cell"] = reader["CELL"];
                        //newRow["Prevpris"] = reader["PREVPRIS1"];
                        newRow["Address1"] = reader["ADD1"];
                        newRow["Address2"] = reader["ADD2"];
                        newRow["Address3"] = reader["ADD3"];
                        newRow["Town"] = GetTownsFromSql(reader["TOWN"] as string); // foreign key
                        newRow["County"] = reader["COUNTY"];
                        newRow["Country"] = GetCountryFromSql(reader["COUNTRY"] as string); // foreign key
                        newRow["Postcode"] = reader["POSTCODE"];
                        newRow["Tel"] = reader["TEL"];
                        newRow["Fax"] = reader["FAX"];
                        newRow["C_Date"] = reader["C_DATE"];
                        newRow["A_Date"] = reader["A_DATE"];
                        newRow["AmendTime"] = reader["AmendTime"]; //date
                        newRow["Memo"] = reader["Memo"];
                        //newRow["Type1"] = reader["TYPE 1"];
                        //newRow["XmasList"] = reader["XMAS LIST"];
                        //newRow["XmasParty"] = reader["XMAS PARTY"];
                        //newRow["Wing"] = reader["WING"];
                        //newRow["Status"] = reader["STATUS"];
                        //newRow["AnnualReport"] = reader["annual report"];
                        //newRow["Convenanters"] = reader["CONVENANTERS"];
                        //newRow["AnnualReviewOld"] = reader["ANNUAL REVIEW Old"];
                        //newRow["NoFundRaisingLetter"] = reader["NO FUNDRAISING LETTER"];
                        //newRow["NLCopiesRequired"] = reader["NLCopiesRequired"];
                        //newRow["NoNewsLetter"] = reader["NO NEWSLETTER"];
                        //newRow["DontSendEmail"] = reader["DontSendEmail"];
                        //newRow["FrEvent"] = reader["FR EVENT"];
                        //newRow["GiftAidSetup"] = reader["GiftAidSetUp"];
                        //newRow["GiftAidStartDate"] = reader["GiftAidStartDate"];
                        //newRow["GiftAidFormSent"] = reader["GiftAidFormSent"];
                        //newRow["GiftAidFormSentDate"] = reader["GiftAidFormSentDate"];
                        //newRow["GitAidNotApplicable"] = reader["GiftAidNotApplicable"];
                        //newRow["BWY_Number"] = reader["BWY_number"];
                        //newRow["Prison"] = reader["PRISON"]; // foreign key, int
                        //newRow["PersonType"] = reader["LOOKUPTYPE"]; // foreign key, int
                        //newRow["PreviousPrison"] = reader["PRISON ID"]; //lookup for value PREVPRIS1



                        dt.Rows.Add(newRow);
                    }
                }

                reader.Close();
                adapter.Update(dt);

                SqlCommand identOn = new SqlCommand("SET IDENTITY_INSERT " + NewTableName + " ON", SQLConnection);
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
