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

        DataTable _towns = null;

        public object GetTownsFromSql(string townName)
        {
            if (townName == null) return DBNull.Value;

            if (_towns == null)
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Town", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("Town");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "Town");
                sqlAdapter.Fill(sqlCountry);
                _towns = sqlCountry.Tables["Town"];
            }

            var result = _towns.Select("Name = '{0}'".Formatted(townName));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        DataTable _countrys = null;

        public object GetCountryFromSql(string country)
        {
            if (country == null) return DBNull.Value;

            if (_countrys == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Country", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("Country");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "Country");
                sqlAdapter.Fill(sqlCountry);
                _countrys = sqlCountry.Tables["Country"];
            }

            var result = _countrys.Select("Name = '{0}'".Formatted(country));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];

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

        private DataTable _title = null;
        public object GetTitleFromSql(string title)
        {
            if (title == null) return DBNull.Value;

            if (_title == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Titles", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("Titles");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "Titles");
                sqlAdapter.Fill(sqlCountry);
                _title = sqlCountry.Tables["Titles"];
            }

            var result = _title.Select("Name = '{0}'".Formatted(title));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        private DataTable _mailCode = null;
        public object GetMailCodeFromSql(string mailCode)
        {
            if (mailCode == null) return DBNull.Value;

            if (_mailCode == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM MailCode", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("MailCode");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "MailCode");
                sqlAdapter.Fill(sqlCountry);
                _mailCode = sqlCountry.Tables["MailCode"];
            }

            var result = _mailCode.Select("Name = '{0}'".Formatted(mailCode));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        private DataTable _responseType = null;
        public object GetResponseTypeFromSql(string response)
        {
            if (response == null) return DBNull.Value;

            if (_responseType == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM ResponseType", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlCountry = new DataSet("ResponseType");
                sqlAdapter.FillSchema(sqlCountry, SchemaType.Source, "ResponseType");
                sqlAdapter.Fill(sqlCountry);
                _responseType = sqlCountry.Tables["ResponseType"];
            }

            var result = _responseType.Select("Response = '{0}'".Formatted(response));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }
    }
}
