using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Tests
{
    public class Global
    {
        public static string SqlConn
        {
            get
            {
                return @"Server=.\sqlexpress;Database=PPT;User ID=ppt;Password=password;Trusted_Connection=False;";
            }
        }
        public static string AccessConn
        {
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Projects\PPT\Client Documents and MDBs\PPT Friends (no data)_Phoenix.mdb";
            }
        }
    }
}
