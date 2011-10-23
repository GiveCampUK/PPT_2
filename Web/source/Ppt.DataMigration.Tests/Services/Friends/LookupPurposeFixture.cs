using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ppt.DataMigration.Services.Friends;

namespace Ppt.DataMigration.Tests.Services.Friends
{
    [TestFixture]
    public class LookupPurposeFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        LookupPurpose _country;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnFriends);
            _country = new LookupPurpose();
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
