using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void ContactsSet_Inserted(Contacts entity)
        {
            if (entity != null && entity.PersonType.Name == "Prisoner")
            {
                var prisoner = Prisoners.AddNew();
                prisoner.ContactId = entity;
                prisoner.SomeData = "Some prisoner data";
            }
        }

        partial void SearchByLastName_Executed(string LastName, IEnumerable<Contacts> result)
        {
            var prisonersWithMetaData = this.Prisoners.Where(x => x.SomeData != null)
                                                      .Execute().ToList<Prisoner>();

            foreach (var item in result)
            {

            }

        }
    }
}
