using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class LookupPurpose : AbstractTableMigrationService
    {
        public string AccessTableName { get; set; }

        public LookupPurpose()
        {
            AccessTableName = "Lookup Purpose";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
