using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Models
{
    [Table("Contries")]
    public class Country
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }
        [MaxLength(250)]
        public string Name { set; get; }
        public virtual IEnumerable<Movie> Movies{set;get;} 
    }
}
