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
    public class ContactFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Contact _contact;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _contact = new Contact();
            _contact.SQLConnection = _sqlConnection;
            _contact.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _contact.MigrateTable();
        }


    }
}
