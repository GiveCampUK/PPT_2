using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services.Yoga
{
    public class Classes : AbstractTableMigrationService
    {
        public Classes()
        {
            this.AccessTableName = "Classes";
            this.NewTableName = "Classes";
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
                        newRow["TeacherId"] = reader["Teacher ID"];
                        newRow["PrisonId"] = reader["Prison ID"];
                        newRow["ClassDetails"] = reader["Class details"];
                        newRow["Notes"] = reader["Notes"];
                        newRow["ClassMakeup"] = reader["Class makeup"];
                        newRow["ClassGender"] = reader["Class gender"];
                        newRow["DoNotCount"] = reader["Do not count"].AsBool();
                        newRow["DateClassStarted"] = reader["Date class started"];
                        newRow["DateClassStopped"] = reader["Date class stopped"];
                        newRow["DrugClass"] = reader["Drug Class"].AsBool();
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
