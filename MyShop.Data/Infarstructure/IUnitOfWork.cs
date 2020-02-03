﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Infarstructure
{
    public interface IUnitOfWork: IDisposable
    {
        IMovieRepository Movies { get; }
        ICountryRepository Countries { get; }
        int Complete();
    }
}
