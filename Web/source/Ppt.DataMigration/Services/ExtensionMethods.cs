using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services
{
    public static class ExtensionMethods
    {
        public static bool AsBool(this object value)
        {
           string val =  Convert.ToString(value);
           return val == "1";
        }

        public static string Cleaned(this OleDbDataReader reader, string field)
        {
            return reader[field].ToString().Replace("'", "''");
        }

        public static object GetNullOrField(this OleDbDataReader reader, string field)
        {
            var dob = reader.Cleaned(field);
            return string.IsNullOrEmpty(dob) ? DBNull.Value as object : dob;
        }
    }

}
