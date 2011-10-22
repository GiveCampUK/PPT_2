using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.Core.Logging;

namespace Ppt.DataMigration.Services
{
    public abstract class AbstractTableMigrationService
    {
        ILogger _logger = new NullLogger();
        public ILogger Logger
        {
            get
            {
                return _logger;
            }
            set
            {
                _logger = value;
            }

        }

        /// <summary>
        /// I am not sure please update.
        /// </summary>
        public object SourceTable { get; set; }
        public string TargetDatabase { get; set; }
        public string ConnectionString { get; set; }

        public abstract void MigrateTable();
       
    }
}
