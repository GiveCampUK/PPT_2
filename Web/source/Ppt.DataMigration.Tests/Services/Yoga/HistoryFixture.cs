using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Data.OleDb;
using Ppt.DataMigration.Services.Yoga;


namespace Ppt.DataMigration.Tests.Services.Yoga
{
    [TestFixture]
    public class HistoryFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        History _service;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnYoga);
            _service = new History();
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
