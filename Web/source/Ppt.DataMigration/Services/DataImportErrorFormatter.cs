using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Services
{
    public class DataImportErrorFormatter
    {
        public static string FormatErrorMessage(string sourceDb, string sourceTable, string destinationTable, string identifier, string exception)
        {
            return String.Format("Error importing from {0} in {1} to {2}, Identifier [{3}]: {4}", sourceDb, sourceTable, destinationTable, identifier, exception);
        } // FormatErrorMEssage()
    }
}
