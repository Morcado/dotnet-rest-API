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
    [Route("directores")]
    public class DirectoresController : ControllerBase
    {
        private readonly IDirectoresRepository _directoresRepository;
        private readonly IMapper _mapper;

        public DirectoresController(IDirectoresRepository directoresRepository, IMapper mapper)
        {
            _directoresRepository = directoresRepository ??
                throw new ArgumentNullException(nameof(directoresRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        // GET: obtener directores
        [HttpGet]
        public ActionResult<IEnumerable<Director>> ObtenerDirectores()
        {
            var directores = _directoresRepository.ObtenerDirectores();
            
            return Ok(_mapper.Map<IEnumerable<DirectorDto>>(directores));
        }

        [HttpGet("{idDirector}", Name = "ObtenerDirector")]
        // GET: obtener director
        public ActionResult<Director> ObtenerDirector(Guid idDirector)
        {
            var director = _directoresRepository.ObtenerDirector(idDirector);

            return Ok(_mapper.Map<DirectorDto>(director));
        }

        // POST: crear director
        [HttpPost]
        public ActionResult CrearDirector(DirectorParaCrearDto director)
        {
            var directorCreado = _mapper.Map<Director>(director);

            _directoresRepository.CrearDirector(directorCreado);
            _directoresRepository.Guardar();

            var directorParaMostrar = _mapper.Map<DirectorDto>(directorCreado);

            return CreatedAtRoute("ObtenerDirector", 
                new
            {
                idDirector = directorParaMostrar.Id
            }, directorParaMostrar);

            //return Ok();
        }
    }
}
