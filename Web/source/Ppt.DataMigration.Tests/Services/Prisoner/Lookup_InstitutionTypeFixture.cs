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
    public class Lookup_InstitutionTypeFixture
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_InstitutionType _institution;

        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _institution = new Lookup_InstitutionType();
            _institution.SQLConnection = _sqlConnection;
            _institution.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _institution.MigrateTable();
        }


    }
}
