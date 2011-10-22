using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Castle.Core.Logging;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace Ppt.DataMigration.Services
{
    public abstract class AbstractTableMigrationService
    {
        ILogger _logger = new NullLogger();
        public ILogger Logger
        {
            get
            {
                return _logger;
            }
            set
            {
                _logger = value;
            }

        }

        /// <summary>
        /// I am not sure please update.
        /// </summary>
        public OleDbConnection AccessConnection { get; set; }
        
        public SqlConnection SQLConnection { get; set; }
        public string AccessTableName { get; set; }
        public string NewTableName { get; set; }


        public abstract void MigrateTable();

        protected OleDbCommand GetSelectAllCommand()
        {
            OleDbCommand oleCmd = AccessConnection.CreateCommand();
            oleCmd.CommandText = "SELECT * FROM " + AccessTableName;

            return oleCmd;
        }

        protected SqlDataAdapter GetSqlAdapter()
        {
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM " + NewTableName, SQLConnection);
            SqlCommandBuilder oOrderDetailsCmdBuilder = new SqlCommandBuilder(sqlAdapter);

            return sqlAdapter;
        }

        protected DataSet GetAndFillDataSet(SqlDataAdapter adapter)
        {
            DataSet dts = new DataSet(NewTableName);
            adapter.FillSchema(dts, SchemaType.Source, NewTableName);
            adapter.Fill(dts);

            return dts;
        }

        protected DataTable GetDataTable(DataSet dts)
        {
            return dts.Tables[NewTableName];
        }
        DataTable _prisonSex = null;

        public object GetPrisonSexFromSql(string prisonSex)
        {
            if (prisonSex == null) return DBNull.Value;

            if (_prisonSex == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM PrisonSex", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("PrisonSex");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "PrisonSex");
                sqlAdapter.Fill(sqlCountry);
                _prisonSex = sqlCountry.Tables["PrisonSex"];
            }

            var result = _prisonSex.Select("Name = '{0}'".Formatted(prisonSex));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"]; 

        }

    }
}
