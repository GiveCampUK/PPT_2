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

        DataTable _titles = null;

        public object GetTitleSql(string title)
        {
            if (title == null) return DBNull.Value;

            if (_titles == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Titles", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlTitles = new DataSet("Titles");
                sqlAdapter.FillSchema(sqlTitles, SchemaType.Source, "Titles");
                sqlAdapter.Fill(sqlTitles);
                _titles = sqlTitles.Tables["Titles"];
            }

            var result = _titles.Select("Name = '{0}'".Formatted(title));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];

        }

        DataTable _mailCodes = null;

        public object GetMailCodeSql(string mailCode)
        {
            if (mailCode == null) return DBNull.Value;

            if (_mailCodes == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM MailCode", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlMailCodes = new DataSet("MailCode");
                sqlAdapter.FillSchema(sqlMailCodes, SchemaType.Source, "MailCode");
                sqlAdapter.Fill(sqlMailCodes);
                _titles = sqlMailCodes.Tables["MailCode"];
            }

            var result = _titles.Select("Name = '{0}'".Formatted(mailCode));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];

        }

        DataTable _prisons = null;

        public object GetPrisonSql(string prison)
        {
            if (prison == null) return DBNull.Value;

            if (_prisons == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Prison", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlPrisons = new DataSet("Prison");
                sqlAdapter.FillSchema(sqlPrisons, SchemaType.Source, "Prison");
                sqlAdapter.Fill(sqlPrisons);
                _titles = sqlPrisons.Tables["Prison"];
            }

            var result = _titles.Select("Name = '{0}'".Formatted(prison));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        DataTable _personTypes = null;

        public object GetPersonTypeSql(string personType)
        {
            if (personType == null) return DBNull.Value;

            if (_personTypes == null)
            {

                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM PersonType", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlPersonTypes = new DataSet("PersonType");
                sqlAdapter.FillSchema(sqlPersonTypes, SchemaType.Source, "PersonType");
                sqlAdapter.Fill(sqlPersonTypes);
                _titles = sqlPersonTypes.Tables["PersonType"];
            }

            var result = _titles.Select("ShortCode = '{0}'".Formatted(personType));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        DataTable _contacts = null;

        public object GetContactSql(string oldRefNo, string sourceDb)
        {
            if (oldRefNo == null) return DBNull.Value;

            if (_contacts == null)
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Contacts", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlContacts = new DataSet("Contacts");
                sqlAdapter.FillSchema(sqlContacts, SchemaType.Source, "Contacts");
                sqlAdapter.Fill(sqlContacts);
                _titles = sqlContacts.Tables["Contacts"];
            }

            var result = _titles.Select("OldRefNo = '{0}' AND OldDb = '{1}'".Formatted(oldRefNo, sourceDb));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        DataTable _responseTypes = null;

        public object GetResponseTypeSql(string responseType)
        {
            if (responseType == null) return DBNull.Value;

            if (_responseTypes == null)
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM ResponseType", SQLConnection);

                SqlCommandBuilder oOrderDetailsCmdBuilder = new
                SqlCommandBuilder(sqlAdapter);

                DataSet sqlResponseTypes = new DataSet("ResponseType");
                sqlAdapter.FillSchema(sqlResponseTypes, SchemaType.Source, "ResponseType");
                sqlAdapter.Fill(sqlResponseTypes);
                _titles = sqlResponseTypes.Tables["ResponseType"];
            }

            var result = _titles.Select("Response = '{0}'".Formatted(responseType));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }
    }
}
