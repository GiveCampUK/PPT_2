﻿using System;
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("Town");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "Town");
                sqlAdapter.Fill(dts);
                _towns = dts.Tables["Town"];
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("Country");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "Country");
                sqlAdapter.Fill(dts);
                _countrys = dts.Tables["Country"];
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("PrisonSex");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "PrisonSex");
                sqlAdapter.Fill(dts);
                _prisonSex = dts.Tables["PrisonSex"];
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("Titles");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "Titles");
                sqlAdapter.Fill(dts);
                _titles = dts.Tables["Titles"];
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

                SqlCommandBuilder oOrderDetailsCmdBuilder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("MailCode");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "MailCode");
                sqlAdapter.Fill(dts);
                _mailCodes = dts.Tables["MailCode"];
            }

            var result = _mailCodes.Select("Name = '{0}'".Formatted(mailCode));
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("Prison");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "Prison");
                sqlAdapter.Fill(dts);
                _prisons = dts.Tables["Prison"];
            }

            var result = _prisons.Select("Name = '{0}'".Formatted(prison));
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("PersonType");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "PersonType");
                sqlAdapter.Fill(dts);
                _personTypes = dts.Tables["PersonType"];
            }

            var result = _personTypes.Select("ShortCode = '{0}'".Formatted(personType));
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("Contacts");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "Contacts");
                sqlAdapter.Fill(dts);
                _contacts = dts.Tables["Contacts"];
            }

            var result = _contacts.Select("OldRefNo = '{0}' AND OldDb = '{1}'".Formatted(oldRefNo, sourceDb));
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

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("ResponseType");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "ResponseType");
                sqlAdapter.Fill(dts);
                _responseTypes = dts.Tables["ResponseType"];
            }

            var result = _responseTypes.Select("Response = '{0}'".Formatted(responseType));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        DataTable _giftTypes = null;

        public object GetGiftTypeSql(string giftType)
        {
            if (giftType == null) return DBNull.Value;

            if (_giftTypes == null)
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM GiftType", SQLConnection);

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("GiftType");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "GiftType");
                sqlAdapter.Fill(dts);
                _giftTypes = dts.Tables["GiftType"];
            }

            var result = _giftTypes.Select("ShortCode = '{0}'".Formatted(giftType));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        DataTable _contactOldRefs = null;

        public object GetContactOldRefSql(string corresp)
        {
            if (corresp == null) return DBNull.Value;

            if (_contactOldRefs == null)
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM Contacts", SQLConnection);

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("Contacts");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "Contacts");
                sqlAdapter.Fill(dts);
                _contactOldRefs = dts.Tables["Contacts"];
            }

            var result = _contactOldRefs.Select("OldRefNo = '{0}'".Formatted(corresp));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }

        private DataTable _nlOrderTypes = null;
        
        public object GetNLOrderTypes(string orderType)
        {
            if (orderType == null) return DBNull.Value;

            if (_nlOrderTypes == null)
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter("SELECT * FROM NLAddressOrderType", SQLConnection);

                SqlCommandBuilder builder = new SqlCommandBuilder(sqlAdapter);

                DataSet dts = new DataSet("NLAddressOrderType");
                sqlAdapter.FillSchema(dts, SchemaType.Source, "NLAddressOrderType");
                sqlAdapter.Fill(dts);
                _nlOrderTypes = dts.Tables["Contacts"];
            }

            var result = _nlOrderTypes.Select("Name = '{0}'".Formatted(orderType));
            if (result.Length == 0) return DBNull.Value;
            else return result[0]["Id"];
        }
    }
}
