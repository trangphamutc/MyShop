using MyShop.Model.Models;
using MyShop.Web.Infrastructure.Core;
using MyShopService;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        public HttpResponseMessage Post( HttpRequestMessage request, Movie movie)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else {
                    var MovieCop = _movieService.Add(movie);
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
        public HttpResponseMessage Put(HttpRequestMessage request, Movie movie)
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
                    _movieService.Update(movie);
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
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var listMovie = _movieService.GetAll();

                    response = request.CreateResponse(HttpStatusCode.OK, listMovie);
                }
                return response;
            });
        }
        
    }
}