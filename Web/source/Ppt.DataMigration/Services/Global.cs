using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services
{
    internal static class Global
    {
        
        private static string _sqlConn= @"Server={0};Database={1};User ID={2};Password={3};Trusted_Connection=False;";
         
        private static string _accessConn= @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}";


        public static string SqlConn(string server, string database, string username, string password)
        {
            return _sqlConn.Formatted(server, database, username, password);
        }
        public static string AccessConn(string path)
        {
            return _accessConn.Formatted(path);
        }

    
    }
}
