using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class LookupType : AbstractTableMigrationService
    {
        public LookupType()
        {
            AccessTableName = "Lookup Type";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
