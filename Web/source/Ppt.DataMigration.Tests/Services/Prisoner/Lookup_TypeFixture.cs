using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ppt.DataMigration.Services.Friends;
using Ppt.DataMigration.Services.Prisoner;

namespace Ppt.DataMigration.Tests.Services.Friends
{
    [TestFixture]
    public class Lookup_TypeFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_Type _country;
        
        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _country = new Lookup_Type();
            _country.SQLConnection = _sqlConnection;
            _country.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _country.MigrateTable();
        }

        
    }
}
