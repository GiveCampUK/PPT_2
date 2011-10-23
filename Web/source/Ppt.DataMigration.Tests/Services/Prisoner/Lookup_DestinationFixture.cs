using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ppt.DataMigration.Services.Prisoner;

namespace Ppt.DataMigration.Tests.Services.Prisoner
{
    [TestFixture]
    public class Lookup_DestinationFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_Destination _destination;
        
        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _destination = new Lookup_Destination();
            _destination.SQLConnection = _sqlConnection;
            _destination.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _destination.MigrateTable();
        }

        
    }
}
