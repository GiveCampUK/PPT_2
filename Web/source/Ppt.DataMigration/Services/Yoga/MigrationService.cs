﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Castle.Core.Logging;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Yoga
{
    public class MigrationService : AbstractMigrationService
    {
        public MigrationService(string databasePath, SqlConnection sqlConn)
            : base(databasePath, sqlConn)
        { }

        public override void Migrate()
        {
            RunImporter(new Accreditation());
            
            RunImporter(new Classes());

            RunImporter(new History());

            RunImporter(new WorkshopPrisons());

            RunImporter(new WorkshopTeachers());
            
        }

        
    }
}