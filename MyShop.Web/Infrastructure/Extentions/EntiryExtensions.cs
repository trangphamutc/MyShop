using MyShop.Model.Models;
using MyShop.Web.Mappings;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Infrastructure.Extentions
{
    public static class EntiryExtensions
    {
        public static void UpdateMovie(this Movie movie, MovieViewModel movieViewModel)
        {
            movie.ID = movieViewModel.ID;
            movie.Name = movieViewModel.Name;
            movie.CountryID = movieViewModel.CountryID;
        }
        public static void UpdateCountry(this Country country, CountryViewModel countryView)
        {
            country.ID = countryView.ID;
            country.Name = countryView.Name;
        }
    }
    
}