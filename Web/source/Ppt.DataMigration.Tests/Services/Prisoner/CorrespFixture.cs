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
    public class CorrespFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Corresp _corresp;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _corresp = new Corresp();
            _corresp.SQLConnection = _sqlConnection;
            _corresp.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _corresp.MigrateTable();
        }
    }
}
