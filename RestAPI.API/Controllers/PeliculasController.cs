using Microsoft.AspNetCore.Mvc;
using RestAPI.Data.Entities;
using RestAPI.Data.Repositories;
using System;
using System.Collections.Generic;

namespace RestAPI.API.Controllers
{
    [ApiController]
    [Route("directores/{idDirector}/peliculas")]
    public class PeliculasController : ControllerBase
    {
        private readonly IPeliculasRepository _peliculasRepository;

        public PeliculasController(IPeliculasRepository peliculasRepository)
        {
            _peliculasRepository = peliculasRepository;
        }
        // GET peliculas
        [HttpGet]
        public ActionResult<IEnumerable<Pelicula>> ObtenerPeliculas(string genero)
        {
            var peliculas = _peliculasRepository.ObtenerPeliculas();
            return Ok(peliculas);
        }
        
        [HttpPost]
        public ActionResult CrearPelicula(Pelicula pelicula)
        {
            //Pelicula peliculaCreada = _peliculasRepository.CrearPelicula(pelicula);
            return Ok();   
        }

        // GET pelicula
        [HttpGet("{idPelicula}")]
        public ActionResult<Pelicula> ObtenerVehiculo(Guid idPelicula)
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
