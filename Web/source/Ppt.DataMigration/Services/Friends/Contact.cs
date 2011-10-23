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
                    currentIdentifier = reader["id"].ToString();

                    var results = dt.Select("ID = '{0}'".Formatted(reader["Id"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["OldRefNo"] = reader["RefNo"];
                        newRow["OldDb"] = "FRIEND";
                        newRow["Surname"] = reader["SURNAME"];
                        newRow["Forename"] = reader["FORENAME"];
                        newRow["Title"] = GetTitleSql(reader["TITLE"] as string);
                        newRow["Position"] = reader["POSITION"];
                        newRow["MailName"] = reader["MAILNAME"];
                        newRow["Salutation"] = reader["SALUTATION"];
                        newRow["Type"] = reader["TYPE"];
                        newRow["EmailAddress"] = reader["EmailAddress"];
                        newRow["Source"] = reader["SOURCE"];
                        newRow["DOB"] = reader["DOB"];
                        newRow["MailCode"] = GetMailCodeSql(reader["MAILCODE"] as string);
                        newRow["Lost"] = reader["LOST"];
                        newRow["Deceased"] = reader["DECEASED"];
                        //newRow["ArchivePrisonName"] = reader[""];
                        newRow["PNumber"] = reader["PNUMBER"];
                        newRow["Cell"] = reader["CELL"];
                        newRow["Prevpris"] = reader["PREVPRIS"];
                        newRow["Address1"] = reader["ADD1"];
                        newRow["Address2"] = reader["ADD2"];
                        newRow["Address3"] = reader["ADD3"];
                        newRow["Town"] = reader["TOWN"];
                        newRow["County"] = reader["COUNTY"];
                        newRow["Country"] = reader["COUNTRY"];
                        newRow["Postcode"] = reader["POSTCODE"];
                        newRow["Tel"] = reader["TEL"];
                        newRow["Fax"] = reader["FAX"];
                        newRow["C_Date"] = reader["C_DATE"];
                        newRow["A_Date"] = reader["A_DATE"];
                        //newRow["AmendTime"] = reader["RefNo"];
                        newRow["Memo"] = reader["MEMO"];
                        //newRow["Type1"] = reader["RefNo"];
                        //newRow["ArchivePrevPris1"] = reader[""];
                        newRow["XmasList"] = reader["XMAS LIST"];
                        newRow["XmasParty"] = reader["XMAS PARTY"];
                        newRow["Wing"] = reader["WING"];
                        newRow["Status"] = reader["STATUS"];
                        newRow["AnnualReport"] = reader["annual report"];
                        newRow["Convenaters"] = reader["COVENANTERS"];
                        newRow["AnnualReviewOld"] = reader["ANNUAL REVIEW Old"];
                        newRow["NoFundRaisingLetter"] = reader["NO FUNDRAISING LETTER"];
                        newRow["NLCopiesRequired"] = reader["NLCopiesRequired"];
                        newRow["NoNewsLetter"] = reader["NO NEWSLETTER"];
                        newRow["DontSendEmail"] = reader["DontSendEmail"];
                        newRow["FrEvent"] = reader["FR EVENT"];
                        newRow["GiftAidSetup"] = reader["GiftAidSetUp"];
                        newRow["GiftAidStartDate"] = reader["GiftAidStartDate"];
                        newRow["GiftAidFormSent"] = reader["GiftAidFormSent"];
                        newRow["GiftAidFromSentDate"] = reader["GiftAidFormSentDate"];
                        newRow["GiftAidNotApplicable"] = reader["GiftAidNotApplicable"];
                        newRow["BWY_Number"] = reader["BWY_number"];
                        newRow["Prison"] = reader["PRISON"];
                        newRow["PersonType"] = GetPersonTypeSql(reader["TYPE"] as string);
                        newRow["PreviousPrison"] = GetPrisonSql(reader["PREVPRIS"] as string);
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
