using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Model.Models
{
    [Table ("Movies")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(250)]
        [Column(TypeName ="nvarchar")]
        public string Name { set; get; }
        [MaxLength(50)]
        public string CountryID { set; get; }
        [ForeignKey("CountryID")]
        public virtual Country Country { set; get; }

    }
}
