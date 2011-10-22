using System.Collections.Generic;
using System.Web.Mvc;
using PPT.Web.Data;

namespace PPT.Web.Models
{
    public static class ContactsViewModel
    {
        public static List<SelectListItem> Titles(this Contact domainObject)
        {
            var list = new List<SelectListItem>
            {
                new SelectListItem {Text = "Mr", Value = "1"},
                new SelectListItem {Text = "Mrs", Value = "2"}
            };

            //foreach(var item in list)
            //{
            //    if(Model.Title.GetValueOrDefault("") == item.Text)
            //}

            return list;
        }
    }
}