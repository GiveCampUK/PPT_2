using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class Writers : AbstractTableMigrationService
    {
        public Writers()
        {
            this.AccessTableName = "Accreditation";
            this.NewTableName = "Accreditation";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
