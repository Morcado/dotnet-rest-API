using RestAPI.Data.Entities;
using System;
using System.Collections.Generic;

namespace RestAPI.Data.Repositories
{
    public interface IPeliculasRepository
    {
        IEnumerable<Pelicula> ObtenerPeliculas();
        Pelicula ObtenerPelicula(Guid id);
    }
}
