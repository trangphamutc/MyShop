using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infarstructure
{
    public interface IMovieRepository:IRepositoty<Movie>
    {
        IEnumerable<Movie> GetMoviesWithCountry(int pageIndex, int pageSize, string coutryID);
        void Remove(int id);
    }
}
