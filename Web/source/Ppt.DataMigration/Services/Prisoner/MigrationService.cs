using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Castle.Core.Logging;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class MigrationService : IDatabaseMigrationService
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

        OleDbConnection _connection;
        SqlConnection _sqlConn;

        public void Migrate(string databasePath, System.Data.SqlClient.SqlConnection sqlConn)
        {
            string oleConnstring = Global.AccessConn(databasePath);
            _connection = new OleDbConnection(oleConnstring);
            _sqlConn = sqlConn;
            
            ConfigureImporter(new Lookup_PostTown());
            
            ConfigureImporter(new Lookup_Country());

            ConfigureImporter(new Lookup_Destination());

            ConfigureImporter(new Lookup_InstitutionType());

            ConfigureImporter(new Lookup_Response());

            ConfigureImporter(new Lookup_Type());

            ConfigureImporter(new Lookup_Prisons());

            ConfigureImporter(new Lookup_Letter_Writers());
            
        }

        public void ConfigureImporter(AbstractTableMigrationService migration)
        {
            migration.AccessConnection = _connection;
            migration.SQLConnection = _sqlConn;
            migration.Logger = _logger;
            migration.MigrateTable();
        }
    }
}
