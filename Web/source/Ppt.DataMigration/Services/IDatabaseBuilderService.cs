using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Ppt.DataMigration.Services
{
    public interface IDatabaseBuilderService
    {
        void Build(SqlConnection sqlConn);
    }
}
