﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services.Yoga
{
    public class History : AbstractTableMigrationService
    {
        public History()
        {
            AccessTableName = "History";
            NewTableName = "History";
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
                        newRow["Id"] = reader["ID"];
                        newRow["TeacherId"] = reader["Teacher ID"];
                        newRow["Date"] = reader["Date"];
                        newRow["History"] = reader["History"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                this.Logger.Error(DataImportErrorFormatter.FormatErrorMessage(this.AccessConnection.Database, this.AccessTableName, this.NewTableName, currentIdentifier, ex.Message));
            }
            finally
            {
                AccessConnection.Close();
                SQLConnection.Close();//should we open and close for each database?
            }
        }
    }
}