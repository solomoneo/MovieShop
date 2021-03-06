﻿using MovieShop.Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieShop.Core.ServiceInterfaces
{
    public interface ICastService
    {
        Task<Cast> GetCastDetails(int id);
        Task<IEnumerable<Movie>> GetMoviesByCast(int id);
    }
}
