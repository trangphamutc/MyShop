using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infarstructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieDbContext _context;
        public UnitOfWork(MovieDbContext context)
        {
            _context = context;
            Movies = new MovieRepository(_context);
            Countries = new CountryRepository(_context);
        }

        public IMovieRepository Movies { get; private set; }
        public ICountryRepository Countries { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
