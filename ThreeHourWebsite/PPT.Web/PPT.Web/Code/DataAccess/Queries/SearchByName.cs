using NHibernate;
using NHibernate.Criterion;
using PPT.Web.Code.Domain;
using PPT.Web.Models;

namespace PPT.Web.Code.DataAccess.Queries
{
    public class SearchByName
    {
        private readonly ISession _session;

        public SearchByName(ISession session)
        {
            _session = session;
        }

        public PageOf<Contact> Execute(string terms)
        {

            const int pageSize = 150;
            var count = _session.QueryOver<Contact>()
                                   .Where(Restrictions.On<Contact>(x => x.Forename).IsLike(terms)
                                          || Restrictions.On<Contact>(x => x.Surname).IsLike(terms))
                                   .RowCount();

            var nameMatch = _session.QueryOver<Contact>()
                                   .Where(Restrictions.On<Contact>(x => x.Forename).IsLike(terms)
                                          || Restrictions.On<Contact>(x => x.Surname).IsLike(terms))
                                   .Take(pageSize)
                                   .List();

            return new PageOf<Contact>(nameMatch, pageSize, 1) { TotalResults = count };
        }
    }
}