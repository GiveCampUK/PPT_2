using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services.Yoga
{
    public class WorkshopPrisons : AbstractTableMigrationService
    {
        public WorkshopPrisons()
        {
            AccessTableName = "[Workshop Prisons]";
            NewTableName = "WorkShopPrisons";
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
                        newRow["PrisonId"] = reader["Prison ID"];
                        newRow["Workshop"] = reader["Workshop"];
                        newRow["Date"] = reader["Date"];
                        newRow["Notes"] = reader["Notes"];
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
