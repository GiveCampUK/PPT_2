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
    public partial class ContactList
    {
        partial void ContactList_Activated()
        {

        }

        partial void ContactsSet_SelectionChanged()
        {
            if (ContactsSet.SelectedItem.PersonType != null)
            {
                switch (ContactsSet.SelectedItem.PersonType.Name)
                {
                    case "Prisoner":
                        // Hide irrelevant tabs
                        Show("Prisoner");
                        break;

                    default:
                        Hide("Prisoner");
                        break;
                }
            }
        }

        private void Hide(string controlName)
        {
            this.FindControl(controlName).IsVisible = false;
        }

        private void Show(string controlName)
        {
            this.FindControl(controlName).IsVisible = true;
        }

        partial void ContactList_Saving(ref bool handled)
        {
            // Write your code here.
            System.Diagnostics.Debug.WriteLine("Break");

            
        }

        partial void ContactList_Saved()
        {
            // Write your code here.
            
        }
    }
}
