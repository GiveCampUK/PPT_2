using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPT.Web.Data;

namespace PPT.Web.Code
{
    public class ContactApplicationService
    {
        private readonly PPTEntities session;

        public ContactApplicationService(PPTEntities session)
        {
            this.session = session;
        }
        
        public ContactApplicationService(): this(new PPTEntities())
        {
        }

        public IList<Contact> RetrievePageOfContacts(int pageNumber, int pageSize)
        {
            if(pageNumber <= 0)
            {
                throw new ArgumentException("Don't give me a less than zero page number, you shit.");
            }

            if(pageSize <= 0)
            {
                throw new ArgumentException("I need a page size that's not negative");
            }

            var myContacts = session.Contacts.OrderBy(x => x.Id).Skip((pageNumber - 1) * pageSize).Take(pageSize);
            return myContacts.ToList();
        }
    }
}