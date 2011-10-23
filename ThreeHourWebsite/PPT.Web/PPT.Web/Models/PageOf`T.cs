using System.Collections.Generic;

namespace PPT.Web.Models
{
    public class PageOf<T> : List<T>
    {
        public int TotalResults { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

        public PageOf()
        {
        }

        public PageOf(IEnumerable<T> inner)
        {
            AddRange(inner);
        }

        public PageOf(IEnumerable<T> inner, int pageSize, int pageNumber)
            :this(inner)
        {
            PageSize = pageSize;
            PageNumber = pageNumber;
        }
    }
}