using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ppt.DataMigration.Mvp
{
    public interface IProgressView
    {
         int PercentComplete { get; set; }
         string Message { get; set; }

    }
}
