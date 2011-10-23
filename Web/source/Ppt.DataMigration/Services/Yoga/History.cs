using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

                SqlCommand identOff = new SqlCommand("SET IDENTITY_INSERT " + NewTableName + " OFF", SQLConnection);
                identOff.ExecuteScalar();

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
                        newRow["TeacherId"] = GetTeacherFromSql(reader.Cleaned("Teacher ID"));
                        newRow["Date"] = reader["Date"];
                        newRow["History"] = reader["History"];
                        dt.Rows.Add(newRow);
                        adapter.Update(dt);
                    }
                }
                reader.Close();
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
