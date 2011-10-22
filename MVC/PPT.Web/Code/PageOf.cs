using System.Collections.Generic;
using System.Linq;

namespace PPT.Web.Code
{
    public class PageOf<T> : List<T> where T: class
    {
        public int TotalResultsCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public PageOf()
        {
        }

        public PageOf(IEnumerable<T> inner)
        {
            AddRange(inner.ToList());
        }
    }
}