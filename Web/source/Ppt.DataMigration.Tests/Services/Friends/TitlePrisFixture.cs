using System.Data.OleDb;
using System.Data.SqlClient;
using NUnit.Framework;
using Ppt.DataMigration.Services.Friends;

namespace Ppt.DataMigration.Tests.Services.Friends
{
    [TestFixture]
    public class TitlePrisFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        TitlePris _service;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnFriends);
            _service = new TitlePris();
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