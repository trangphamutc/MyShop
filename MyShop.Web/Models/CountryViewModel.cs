using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Mappings
{
    public class CountryViewModel
    {
        public string ID { set; get; }
        
        public string Name { set; get; }
        public virtual IEnumerable<MovieViewModel> Movies { set; get; }
    }
}