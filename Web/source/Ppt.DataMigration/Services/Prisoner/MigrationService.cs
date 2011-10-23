using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Castle.Core.Logging;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class MigrationService : AbstractMigrationService
    {
        public MigrationService(string databasePath, SqlConnection sqlConn)
            : base(databasePath, sqlConn)
        { }

        public override void Migrate()
        {
            RunImporter(new Lookup_PostTown());
            
            RunImporter(new Lookup_Country());

            RunImporter(new Lookup_Destination());

            RunImporter(new Lookup_InstitutionType());

            RunImporter(new Lookup_Response());

            RunImporter(new Lookup_Type());

            RunImporter(new Lookup_Prisons());

            RunImporter(new Lookup_Letter_Writers());

            RunImporter(new Corresp());
            
        }

        
    }
}
