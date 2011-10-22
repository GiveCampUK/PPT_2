using System;
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
                    var results = dt.Select("ID = '{0}'".Formatted(reader["Id"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["Id"] = reader["Id"];
                        dt.Rows.Add(newRow);
                    }
                }
                reader.Close();
                adapter.Update(dt);
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
