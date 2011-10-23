using System.Data.OleDb;
using System.Data.SqlClient;
using NUnit.Framework;
using Ppt.DataMigration.Services.Friends;

namespace Ppt.DataMigration.Tests.Services.Friends
{
    [TestFixture]
    public class Lookup_GtypeFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_Gtype _service;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnFriends);
            _service = new Lookup_Gtype();
            _service.SQLConnection = _sqlConnection;
            _service.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _service.MigrateTable();
        }
    }
}