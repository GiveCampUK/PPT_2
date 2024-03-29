﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services.Yoga
{
    public class Accreditation : AbstractTableMigrationService
    {
        public Accreditation()
        {
            this.AccessTableName = "Accreditation";
            this.NewTableName = "Accreditation";
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
                        newRow["Id"] = reader["Id"];
                        newRow["TeacherId"] = GetContactSql(reader["Teacher Id"].ToString(), "FRIEND");
                        newRow["Accreditation"] = reader["Accreditation"];
                        newRow["Date"] = reader["Date"];
                        newRow["Notes"] = reader["Notes"];
                        dt.Rows.Add(newRow);
                        adapter.Update(dt);
                    }
                }
                reader.Close();
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
