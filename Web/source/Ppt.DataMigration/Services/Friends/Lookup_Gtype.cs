using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Lookup_Gtype : AbstractTableMigrationService
    {
        public string AccessTableName { get; set; }

        public Lookup_Gtype()
        {
            AccessTableName = "Lookup Gtype";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
