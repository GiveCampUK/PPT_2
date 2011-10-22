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
    public class Lookup_InstitutionType
    {
        SqlConnection _sqlConnection;
        OleDbConnection _oleConnection;
        Lookup_InstitutionType _institutionType;
        
        [SetUp]
        public void Setup()
        {
            _sqlConnection = new SqlConnection(Global.SqlConn);
            _oleConnection = new OleDbConnection(Global.AccessConnPrisoners);
            _institutionType = new Lookup_InstitutionType();
            _institutionType.SQLConnection = _sqlConnection;
            _institutionType.AccessConnection = _oleConnection;
        }

        [Test]
        public void Migrate()
        {
            _town.MigrateTable();
        }

        
    }
}
