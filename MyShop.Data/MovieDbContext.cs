using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using MyShop.Model.Models;
namespace MyShop.Data
{
    public class MovieDbContext: IdentityDbContext<ApplicationUser>
    {
        public MovieDbContext() : base("MovieStoreConnection")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Movie> Movies { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Error> Errors { set; get; }
        public static MovieDbContext Create()
        {
            return new MovieDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
