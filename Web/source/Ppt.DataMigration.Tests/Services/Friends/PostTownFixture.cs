﻿using System.Data.OleDb;
using System.Data.SqlClient;
using NUnit.Framework;
using Ppt.DataMigration.Services.Friends;

namespace Ppt.DataMigration.Tests.Services.Friends
{
    [TestFixture]
    public class PostTownFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        PostTown _service;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnFriends);
            _service = new PostTown();
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