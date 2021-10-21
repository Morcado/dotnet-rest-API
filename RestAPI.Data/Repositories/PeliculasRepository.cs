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

        public Pelicula ObtenerPelicula(Guid idPelicula, Guid idDirector)
        {
            return _context.Peliculas.Where(v => v.IdDirector == idDirector).FirstOrDefault(p => p.Id == idPelicula);
        }

        public IEnumerable<Pelicula> ObtenerPeliculas(Guid idDirector)
        {
            return _context.Peliculas.Where(p => p.IdDirector == idDirector).ToList();
        }

        public bool ExisteDirector(Guid idDirector)
        {
            if (idDirector == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(idDirector));
            }
            return _context.Directores.Any(d => d.Id == idDirector);
        }

        public void AgregarPelicula(Guid idDirector, Pelicula pelicula)
        {
            if (idDirector == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(idDirector));
            }

            pelicula.Id = Guid.NewGuid();
            pelicula.IdDirector = idDirector;
            _context.Peliculas.Add(pelicula);
        }

        public bool Guardar()
        {
            return _context.SaveChanges() > 0;
        }

        public bool ExistePelicula(Guid idPelicula)
        {
            if (idPelicula == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(idPelicula));
            }
            return _context.Peliculas.Any(d => d.Id == idPelicula);
        }

        public void ActualizarPelicula(Pelicula pelicula)
        {
        }
    }
}
