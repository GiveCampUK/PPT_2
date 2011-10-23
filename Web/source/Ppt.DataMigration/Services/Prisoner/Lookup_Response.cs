using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Response : AbstractTableMigrationService
    {
        public Lookup_Response()
        {
            AccessTableName = "LOOKUP_RESPONSE";
            NewTableName = "ResponseType";
        }
        public override void MigrateTable()
        {
            
        }
    }
}
