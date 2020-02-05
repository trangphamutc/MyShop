

using AutoMapper;
using MyShop.Model.Models;
using MyShop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyShop.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<Movie, MovieViewModel>();
            Mapper.CreateMap<Country, CountryViewModel>();
        }
    }
}