using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPT.Web.Models
{
    public class ViewModelOf<T>
    {
        public T Model { get; set; }

        public ViewModelOf(T model)
        {
            Model = model;
        }
    }
}