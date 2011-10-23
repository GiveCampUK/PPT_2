using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class SentOut : AbstractTableMigrationService
    {
        public SentOut()
        {
            AccessTableName = "SentOut";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
