using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Model.Models;
namespace MyShop.Data
{
    public class MovieDbContext: DbContext
    {
        public MovieDbContext() : base("MovieStoreConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Movie> Movies { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Error> Errors { set; get; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
