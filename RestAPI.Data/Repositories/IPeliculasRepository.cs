using RestAPI.Data.Entities;
using System;
using System.Collections.Generic;

namespace RestAPI.Data.Repositories
{
    public interface IPeliculasRepository
    {
        IEnumerable<Pelicula> ObtenerPeliculas(Guid idDirector);
        Pelicula ObtenerPelicula(Guid id, Guid idDirector);
        public bool ExisteDirector(Guid idDirector);
        void AgregarPelicula(Guid idDirector, Pelicula pelicula);
        public bool Guardar();
        public bool ExistePelicula(Guid idPelicula);
        void ActualizarPelicula(Pelicula pelicula);
    }
}
