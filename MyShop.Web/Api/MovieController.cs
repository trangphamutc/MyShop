using MyShop.Model.Models;
using MyShop.Web.Infrastructure.Core;
using MyShop.Web.Models;
using MyShopService;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyShop.Web.Infrastructure.Extentions;
using AutoMapper;

namespace MyShop.Web.Api
{
    [RoutePrefix("api/movie")]

    public class MovieController : ApiControllerBase
    {
        IMovieService _movieService;
        public MovieController(IErrorService errorService, IMovieService movieService)
            :base(errorService)
        {
            this._movieService = movieService;
        }
        [Route("add")]
        public HttpResponseMessage Post( HttpRequestMessage request, MovieViewModel movieVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else {
                    Movie newMovie = new Movie();
                    newMovie.UpdateMovie(movieVm);
                    var movie = _movieService.Add(newMovie);
                    _movieService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _movieService.Delete(id);
                    _movieService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, MovieViewModel movieVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var movieDb = _movieService.GetById(movieVm.ID);
                    movieDb.UpdateMovie(movieVm);
                    _movieService.Update(movieDb);
                    _movieService.Save();

                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;

            });
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>{
                 
                var listMovie = _movieService.GetAll();
                var listMovieVm = Mapper.Map<List<MovieViewModel>>(listMovie);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listMovieVm);
               
                return response;
            });
        }
        
    }
}