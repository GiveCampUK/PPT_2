using NHibernate;
using PPT.Web.Code.Domain;
using PPT.Web.Models;

namespace PPT.Web.Code.DataAccess.Queries
{
    public class RetrievePageOfContacts
    {
        private readonly ISession _session;

        public RetrievePageOfContacts(ISession session)
        {
            _session = session;
        }

        public PageOf<Contact> Execute(int pageNumber, int pageSize, bool filterInvalidNames = true)
        {
            var countQuery = _session.QueryOver<Contact>();
            var resultsQuery = _session.QueryOver<Contact>();

            if (filterInvalidNames)
            {
                countQuery = ApplyInvalidNameFilter(countQuery);
                resultsQuery = ApplyInvalidNameFilter(resultsQuery);
            }

            var count = countQuery.OrderBy(x => x.Surname).Asc
                                  .OrderBy(x => x.Forename).Asc
                                  .RowCount();

            var results = resultsQuery.OrderBy(x => x.Surname).Asc
                                      .OrderBy(x => x.Forename).Asc
                                      .Skip((pageNumber - 1) * pageSize)
                                      .Take(pageSize)
                                      .List();

            return new PageOf<Contact>(results, pageSize, pageNumber) { TotalResults = count };
        }
        
        private static IQueryOver<Contact, Contact> ApplyInvalidNameFilter(IQueryOver<Contact, Contact> q1)
        {
            return q1.Where(x => x.Surname != null && x.Forename != null);
        }
    }
}