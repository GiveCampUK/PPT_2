using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using Ppt.DataMigration.Services.Friends;

namespace Ppt.DataMigration.Services.Prisoner
{
    public class Lookup_Country : Country
    {        
        public Lookup_Country()
        {
            this.AccessTableName = "Lookup_Country";
        }
    }
}
