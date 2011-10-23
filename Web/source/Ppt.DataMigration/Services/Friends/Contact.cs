using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Contact : AbstractTableMigrationService
    {
        public Contact()
        {
            AccessTableName = "Contact";
            NewTableName = "Contacts";
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
                    currentIdentifier = reader["RefNo"].ToString();

                    var results = dt.Select("OldRefNo = '{0}'".Formatted(reader["RefNo"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["OldRefNo"] = reader.Cleaned("RefNo");
                        newRow["OldDb"] = "FRIEND";
                        newRow["Surname"] = reader.Cleaned("SURNAME");
                        newRow["Forename"] = reader.Cleaned("FORENAME");
                        newRow["Title"] = GetTitleSql(reader.Cleaned("TITLE"));
                        newRow["Position"] = reader.Cleaned("POSITION");
                        newRow["MailName"] = reader.Cleaned("MAILNAME");
                        newRow["Salutation"] = reader.Cleaned("SALUTATION");
                        newRow["Type"] = reader.Cleaned("TYPE");
                        newRow["EmailAddress"] = reader.Cleaned("EmailAddress");
                        newRow["Source"] = reader.Cleaned("SOURCE");
                        newRow["DOB"] = reader.GetNullOrField("dob");
                        newRow["MailCode"] = GetMailCodeSql(reader.Cleaned("MAILCODE"));
                        newRow["Lost"] = reader.GetNullOrField("LOST");
                        newRow["Deceased"] = reader.Cleaned("DECEASED").AsBool();
                        //newRow["ArchivePrisonName"] = reader[""];
                        newRow["PNumber"] = reader.Cleaned("PNUMBER");
                        newRow["Cell"] = reader.Cleaned("CELL");
                        newRow["Prevpris"] = reader.Cleaned("PREVPRIS");
                        newRow["Address1"] = reader.Cleaned("ADD1");
                        newRow["Address2"] = reader.Cleaned("ADD2");
                        newRow["Address3"] = reader.Cleaned("ADD3");
                        newRow["Town"] = GetTownsFromSql(reader.Cleaned("TOWN"));
                        newRow["County"] = reader.Cleaned("COUNTY");
                        newRow["Country"] = GetCountryFromSql(reader.Cleaned("COUNTRY"));
                        newRow["Postcode"] = reader.Cleaned("POSTCODE");
                        newRow["Tel"] = reader.Cleaned("TEL");
                        newRow["Fax"] = reader.Cleaned("FAX");
                        newRow["C_Date"] = reader.GetNullOrField("C_DATE");
                        newRow["A_Date"] = reader.GetNullOrField("A_DATE");
                        //newRow["AmendTime"] = reader["RefNo"];
                        newRow["Memo"] = reader.Cleaned("MEMO");
                        //newRow["Type1"] = reader["RefNo"];
                        //newRow["ArchivePrevPris1"] = reader[""];
                        newRow["XmasList"] = reader.Cleaned("XMAS LIST");
                        newRow["XmasParty"] = reader.Cleaned("XMAS PARTY");
                        newRow["Wing"] = reader.Cleaned("WING");
                        newRow["Status"] = reader.Cleaned("STATUS");
                        newRow["AnnualReport"] = reader.Cleaned("annual report");
                        newRow["Convenaters"] = reader.Cleaned("COVENANTERS");
                        newRow["AnnualReviewOld"] = reader.Cleaned("ANNUAL REVIEW Old");
                        newRow["NoFundRaisingLetter"] = reader.Cleaned("NO FUNDRAISING LETTER");
                        newRow["NLCopiesRequired"] = reader.Cleaned("NLCopiesRequired");
                        newRow["NoNewsLetter"] = reader.Cleaned("NO NEWSLETTER");
                        newRow["DontSendEmail"] = reader.Cleaned("DontSendEmail");
                        newRow["FrEvent"] = reader.Cleaned("FR EVENT");
                        newRow["GiftAidSetup"] = reader.Cleaned("GiftAidSetUp");
                        newRow["GiftAidStartDate"] = reader.GetNullOrField("GiftAidStartDate");
                        newRow["GiftAidFormSent"] = reader.Cleaned("GiftAidFormSent");
                        newRow["GiftAidFromSentDate"] = reader.GetNullOrField("GiftAidFormSentDate");
                        newRow["GiftAidNotApplicable"] = reader.Cleaned("GiftAidNotApplicable");
                        newRow["BWY_Number"] = reader.Cleaned("BWY_number");
                        newRow["Prison"] = GetPrisonSql(reader.Cleaned("PRISON"));
                        newRow["PersonType"] = GetPersonTypeSql(reader.Cleaned("TYPE"));
                        newRow["PreviousPrison"] = GetPrisonSql(reader.Cleaned("PREVPRIS"));
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                adapter.Update(dt);
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
