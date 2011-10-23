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
        public static string AccessConnFriends
        {
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kxm\Desktop\scrambled databases\Phoenix.mdb";
            }
        }

        public static string AccessConnPrisoners
        {
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kxm\Desktop\scrambled databases\Prisoners.mdb";
            }
        }

        public static string AccessConnYoga
        {
            get
            {
                return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kxm\Desktop\scrambled databases\Yoga.mdb";
            }
        }
    }
}
