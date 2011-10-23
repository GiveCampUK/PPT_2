using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ppt.DataMigration.Services.Friends;
using Ppt.DataMigration.Services.Prisoner;

namespace Ppt.DataMigration.Tests.Services.Prisoner
{
    [TestFixture]
    public class Lookup_PrisonFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_Prisons _prisons;
        
        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _prisons = new Lookup_Prisons();
            _prisons.SQLConnection = _sqlConnection;
            _prisons.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _prisons.MigrateTable();
        }

        
    }
}
