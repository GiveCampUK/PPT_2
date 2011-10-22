using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Type : AbstractTableMigrationService
    {
        public string AccessTableName { get; set; }

        public Lookup_Type()
        {
            AccessTableName = "Lookup_Type";
        }

        public override void MigrateTable()
        {
        }
    }
}
