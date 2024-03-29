﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;

namespace Ppt.DataMigration.Services
{
    public class DatabaseBuilderService : IDatabaseBuilderService
    {
        string _databaseName;

        public void Build(SqlConnection sqlConn, string databaseName)
        {
            _databaseName = databaseName;

            try
            {
                sqlConn.Open();

                // DROP the DB
                using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Ppt.DataMigration.Scripts.dbo.PPT.Create.sql"))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();
                    this.RunBuildScript(sqlConn, result);
                } // End Using

                // Create the Tables
                string[] resourceFileNames = this.GetDBScriptFileNames();

                for (int i = 0; i < resourceFileNames.Count(); i++)
                {
                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceFileNames[i]))
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string result = reader.ReadToEnd();
                        this.RunScript(sqlConn, result);
                    } // End Using
                } // End For

            }
            finally
            {
                sqlConn.Close();
            }
        } // Build()

        private void RunScript(SqlConnection connection, string sql)
        {
            sql = String.Format("USE [{0}]\n", _databaseName) + sql;

            Regex regex = new Regex("^GO", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string[] lines = regex.Split(sql);

            SqlTransaction transaction = connection.BeginTransaction();

            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.Connection = connection;
                cmd.Transaction = transaction;

                foreach (string line in lines)
                {
                    if (line.Length > 0)
                    {
                        cmd.CommandText = line;
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            cmd.ExecuteNonQuery();
                        } // End Try
                        catch (SqlException)
                        {
                            transaction.Rollback();
                            throw;
                        } // End Catch
                    } // End If
                } // End Foreach
            } // End Using

            transaction.Commit();
        } // RunScript()

        private void RunBuildScript(SqlConnection connection, string sql)
        {
            sql = sql.Replace("#DATABASE_NAME#", _databaseName);

            // This switches context back to the PPT DB after the Drop and re-Create
            sql = sql + String.Format("USE [{0}]\r\nGO\r\n", _databaseName);

            Regex regex = new Regex("^GO", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string[] lines = regex.Split(sql);

            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.Connection = connection;

                foreach (string line in lines)
                {
                    if (line.Length > 0)
                    {
                        cmd.CommandText = line;
                        cmd.CommandType = CommandType.Text;

                        try
                        {
                            cmd.ExecuteNonQuery();
                        } // End Try
                        catch (SqlException)
                        {
                            throw;
                        } // End Catch
                    } // End If
                } // End Foreach
            } // End Using
        } // RunScript()

        private string[] GetDBScriptFileNames()
        {
            string[] list = new string[22];
            list[0] = "Ppt.DataMigration.Scripts.dbo.Town.Table.sql";
            list[1] = "Ppt.DataMigration.Scripts.dbo.Titles.Table.sql";
            list[2] = "Ppt.DataMigration.Scripts.dbo.PrisonSex.Table.sql";
            list[3] = "Ppt.DataMigration.Scripts.dbo.PurposeType.Table.sql";
            list[4] = "Ppt.DataMigration.Scripts.dbo.ResponseType.Table.sql";
            list[5] = "Ppt.DataMigration.Scripts.dbo.Country.Table.sql";
            list[6] = "Ppt.DataMigration.Scripts.dbo.GiftType.Table.sql";
            list[7] = "Ppt.DataMigration.Scripts.dbo.InstitutionType.Table.sql";
            list[8] = "Ppt.DataMigration.Scripts.dbo.MailCode.Table.sql";
            list[9] = "Ppt.DataMigration.Scripts.dbo.NLAddressOrderType.Table.sql";
            list[10] = "Ppt.DataMigration.Scripts.dbo.PersonType.Table.sql";
            list[11] = "Ppt.DataMigration.Scripts.dbo.LetterWriters.Table.sql";
            list[12] = "Ppt.DataMigration.Scripts.dbo.Prison.Table.sql";
            list[13] = "Ppt.DataMigration.Scripts.dbo.Gifts.Table.sql";
            list[14] = "Ppt.DataMigration.Scripts.dbo.Destination.Table.sql";
            list[15] = "Ppt.DataMigration.Scripts.dbo.Contacts.Table.sql";
            list[16] = "Ppt.DataMigration.Scripts.dbo.Accreditation.Table.sql";
            list[17] = "Ppt.DataMigration.Scripts.dbo.Classes.Table.sql";
            list[18] = "Ppt.DataMigration.Scripts.dbo.Corresp.Table.sql";
            list[19] = "Ppt.DataMigration.Scripts.dbo.History.Table.sql";
            list[20] = "Ppt.DataMigration.Scripts.dbo.WorkshopPrisons.Table.sql";
            list[21] = "Ppt.DataMigration.Scripts.dbo.WorkshopTeachers.Table.sql";
            return list;
        }
    }
}
