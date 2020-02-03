using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infarstructure
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        
        public MovieRepository(MovieDbContext context) : base(context)
        {
          
        }

        public IEnumerable<Movie> GetMoviesWithCountry(int pageIndex, int pageSize, string countryID)
        {
            return MovieDbContext.Movies.Where(c => c.CountryID == countryID)
                .OrderBy(c=>c.Name)
                .Skip((pageIndex-1)*pageSize)
                .Take(pageSize)
                .ToList();
        }

        public MovieDbContext MovieDbContext
        {
            get
            {
                return MovieDbContext as MovieDbContext;
            }
        }
    }
}
