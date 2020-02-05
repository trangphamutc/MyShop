using MyShop.Web.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Models
{
    public class MovieViewModel
    {
        
        public int ID { set; get; }

        public string Name { set; get; }

        public string CountryID { set; get; }

        public virtual CountryViewModel Country { set; get; }
    }
}