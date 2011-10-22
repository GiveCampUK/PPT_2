using System;
using System.Collections.Generic;
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
    }
}
