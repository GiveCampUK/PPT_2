using FluentNHibernate.Mapping;
using PPT.Web.Code.Domain;

namespace PPT.Web.Code.DataAccess.Mapping
{
    public class ContactMap : ClassMap<Contact>
    {
        public ContactMap()
        {
            Table("Contacts");
            Id(x=>x.Id).GeneratedBy.Identity();
            Map(x => x.Forename);
            Map(x => x.Surname);
            Map(x => x.EmailAddress);
        }
    }
}