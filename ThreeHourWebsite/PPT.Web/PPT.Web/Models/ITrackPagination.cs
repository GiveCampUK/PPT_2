using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPT.Web.Models
{
    public interface ITrackPagination
    {
        int PageNumber { get; }
        int NumberOfPages { get; }
    }
}