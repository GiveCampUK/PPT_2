using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewContacts
    {
        partial void CreateNewContacts_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.ContactsProperty = new Contacts();
        }

        partial void CreateNewContacts_Saved()
        {
            // Write your code here.
            this.Close(false);


            Application.Current.ShowDefaultScreen(this.ContactsProperty);
        }

        partial void CreateNewContacts_Saving(ref bool handled)
        {
            // Write your code here.

        }
    }
}