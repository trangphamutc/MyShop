using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infarstructure
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(MovieDbContext context) : base(context)
        {

        }
    }
}
