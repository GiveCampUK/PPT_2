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
    public class Lookup_PostTownFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_PostTown _town;
        
        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _town = new Lookup_PostTown();
            _town.SQLConnection = _sqlConnection;
            _town.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _town.MigrateTable();
        }

        
    }
}
