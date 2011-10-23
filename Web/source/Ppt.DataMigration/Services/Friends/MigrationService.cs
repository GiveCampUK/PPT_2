using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Castle.Core.Logging;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services.Friends
{
    public class MigrationService : AbstractMigrationService
    {
        public MigrationService(string databasePath, SqlConnection sqlConn)
            : base(databasePath, sqlConn)
        { }

        public override void Migrate()
        {
            RunImporter(new Country());
            RunImporter(new Destination());
            RunImporter(new PostTown());
            RunImporter(new Response());
            RunImporter(new TitlePris());
            RunImporter(new MailCode());
            RunImporter(new Lookup_Gtype());
            RunImporter(new LookupPurpose());
            RunImporter(new Gifts());
            RunImporter(new Corresp());
            RunImporter(new LookupLetterWriters());
            RunImporter(new Writers());


        }
    }
}
