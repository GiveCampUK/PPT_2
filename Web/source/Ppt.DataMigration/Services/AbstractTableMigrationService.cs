using System;
using System.Collections.Generic;
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



        public abstract void MigrateTable();


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

    }
}
