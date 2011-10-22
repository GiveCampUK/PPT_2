using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class MailCode : AbstractTableMigrationService
    {
        public string AccessTableName { get; set; }

        public MailCode()
        {
            AccessTableName = "MailCode";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
