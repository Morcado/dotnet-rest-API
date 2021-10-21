using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Data.Entities;
using RestAPI.Data.Models;
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
        private readonly IMapper _mapper;

        public PeliculasController(IPeliculasRepository peliculasRepository, IMapper mapper)
        {
            _peliculasRepository = peliculasRepository;
            _mapper = mapper;
        }
        // GET peliculas
        [HttpGet]
        public ActionResult<IEnumerable<Pelicula>> ObtenerPeliculas(Guid idDirector)
        {
            if (!_peliculasRepository.ExisteDirector(idDirector))
            {
                return NotFound();
            }

            var peliculas = _peliculasRepository.ObtenerPeliculas(idDirector);
            return Ok(peliculas);
        }
        
        [HttpPost]
        public ActionResult CrearPelicula(Guid idDirector, PeliculaParaCrearDto peliculaCrear)
        {
            if (!_peliculasRepository.ExisteDirector(idDirector))
            {
                return NotFound();
            }

            var pelicula = _mapper.Map<Pelicula>(peliculaCrear);
            _peliculasRepository.AgregarPelicula(idDirector, pelicula);
            _peliculasRepository.Guardar();

            var peliculaParaMostrar = _mapper.Map<PeliculaDto>(pelicula);

            return CreatedAtRoute("ObtenerPelicula",
                    new { idDirector, idPelicula = pelicula.Id },
                    peliculaParaMostrar
                );   
        }

        [HttpPut("{idPelicula}")]
        public ActionResult ModificarPelicula(Guid idDirector, 
            Guid idPelicula, PeliculaParaModificarDto peliculaModificar)
        {
            if (!_peliculasRepository.ExisteDirector(idDirector))
            {
                return NotFound();
            }

            var pelicula = _peliculasRepository.ObtenerPelicula(idPelicula, idDirector);

            if (pelicula == null)
            {
                return NotFound();
            }

            _mapper.Map(peliculaModificar, pelicula);
            _peliculasRepository.ActualizarPelicula(pelicula);
            _peliculasRepository.Guardar();

            return NoContent();

            /*
            var peliculaParaMostrar = _mapper.Map<PeliculaDto>(pelicula);

            return CreatedAtRoute("ObtenerPelicula",
                    new { idDirector, idPelicula = pelicula.Id },
                    peliculaParaMostrar
                );*/
        }


        // GET pelicula
        [HttpGet("{idPelicula}", Name = "ObtenerPelicula")]
        public ActionResult<Pelicula> ObtenerPelicula(Guid idDirector, Guid idPelicula)
        {
            if (!_peliculasRepository.ExisteDirector(idDirector))
            {
                return NotFound();
            }

            var pelicula = _peliculasRepository.ObtenerPelicula(idPelicula, idDirector);

            if (pelicula == null)
            {
                return NotFound();
            }
            return Ok(pelicula);
        }

     }
}
