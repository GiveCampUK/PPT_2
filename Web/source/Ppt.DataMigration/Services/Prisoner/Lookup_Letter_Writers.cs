﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Letter_Writers : AbstractTableMigrationService
    {
        public Lookup_Letter_Writers()
        {
            AccessTableName = "";
            NewTableName = "";
        }

        public override void MigrateTable()
        {
            
        }
    }
}
