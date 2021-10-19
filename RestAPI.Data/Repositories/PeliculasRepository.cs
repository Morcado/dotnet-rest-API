using CourseLibrary.API.DbContexts;
using RestAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.Data.Repositories
{
    public class PeliculasRepository : IPeliculasRepository
    {
        private readonly CineContext _context;

        public PeliculasRepository(CineContext context)
        {
            _context = context;
        }

        public Pelicula ObtenerPelicula(Guid idPelicula)
        {
            return _context.Peliculas.Where(v => v.Id == idPelicula).FirstOrDefault();
        }

        public IEnumerable<Pelicula> ObtenerPeliculas()
        {
            return _context.Peliculas.ToList();
        }
    }
}
