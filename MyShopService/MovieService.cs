using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Data.Infarstructure;
using MyShop.Model.Models;
namespace MyShopService
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Update(Movie movie);
        void GetById(int id);
        void Delete(int id);
    }
    class MovieService : IMovieService
    {
        IMovieRepository _movieRepository;
        IUnitOfWork _unitOfWork;
        public MovieService( IMovieRepository movieRepository, IUnitOfWork unitOfWork)
        {
            this._movieRepository = movieRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Movie movie)
        {
            _movieRepository.Add(movie);
        }
        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie movie)
        {
            _movieRepository.Update(movie);
        }

        public void Delete(int id)
        {
            _movieRepository.Remove(id);
        }
    }
}
