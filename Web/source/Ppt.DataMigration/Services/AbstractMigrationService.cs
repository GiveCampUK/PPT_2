using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using Castle.Core.Logging;

namespace Ppt.DataMigration.Services
{
    public abstract class AbstractMigrationService
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

        public AbstractMigrationService(string databasePath, SqlConnection sqlConn)
        {
            string oleConnstring = Global.AccessConn(databasePath);
            Connection = new OleDbConnection(oleConnstring);
            SqlConn = sqlConn;
        }

        public OleDbConnection Connection { get; set; }
        public SqlConnection SqlConn { get; set; }

        public abstract void Migrate();


        public void RunImporter(AbstractTableMigrationService migration)
        {
            migration.AccessConnection = Connection;
            migration.SQLConnection = SqlConn;
            migration.Logger = _logger;
            migration.MigrateTable();
        }
    }
}
