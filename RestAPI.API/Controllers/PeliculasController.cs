using Microsoft.AspNetCore.Mvc;
using RestAPI.Data.Entities;
using RestAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.API.Controllers
{
    [Route("peliculas")]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculasRepository _peliculasRepository;

        public PeliculasController(IPeliculasRepository peliculasRepository)
        {
            _peliculasRepository = peliculasRepository;
        }
        // GET peliculas
        [HttpGet]
        public ActionResult<Pelicula> Index()
        {
            var peliculas = _peliculasRepository.ObtenerPeliculas();
            return Ok(peliculas);
        }

        // GET pelicula
        [HttpGet("{idPelicula}")]
        public ActionResult<IEnumerable<Pelicula>> ObtenerVehiculo(Guid idPelicula)
        {
            var pelicula = _peliculasRepository.ObtenerPelicula(idPelicula);
            if (pelicula == null)
            {
                return NotFound();
            }
            return Ok(pelicula);
        }

    }
}
