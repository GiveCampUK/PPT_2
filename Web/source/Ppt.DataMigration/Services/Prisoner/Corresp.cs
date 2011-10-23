using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Corresp : AbstractTableMigrationService
    {
        public Corresp()
        {
            AccessTableName = "CORRESP";
            NewTableName = "Corresp";
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
                    var results = dt.Select("CORREF = '{0}'".Formatted(reader["CORREF"]));
                    if (results.Length == 0)
                    {
                        var newRow = dt.NewRow();
                        newRow["CORREF"] = reader["CORREF"]; // pk
                        newRow["OLDCORREF"] = reader["OLDCORREF"];
                        newRow["NUMBER"] = reader["NUMBER"];
                        newRow["REFNO"] = reader["REFNO"];
                        newRow["DATE1"] = reader["DATE1"];
                        newRow["TYPE"] = reader["TYPE"];
                        newRow["FILING"] = reader["FILING"];
                        newRow["RESPONSE"] = GetResponseTypeSql(reader["RESPONSE"] as string); //fk
                        newRow["DESTINATION"] = reader["DESTINATION"];
                        newRow["CORRESPONDENT"] = reader["CORRESPONDENT"];
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
