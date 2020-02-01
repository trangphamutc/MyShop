using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyShop.Model.Models
{
    [Table("Products")]
    public class Product: Auditable
    {
        public string Alias { set; get; }
        public int Warranty { set; get; }
        public int CategoryID { set; get; }
        public string Content { set; get; }
        public string Description { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int ID { set; get; }
        public string Image { set; get; }
        public XElement MoreImages { set; get; }
        public string Name { set; get; }
        public decimal? PromotionPrice { set; get; }
        public int? ViewCount { set; get; }
   
    }
}
