using Microsoft.AspNetCore.Mvc;
using RestAPI.Data.Entities;
using System;
using System.Collections.Generic;

namespace RestAPI.API.Controllers
{
    [ApiController]
    [Route("directores")]
    public class DirectoresController : ControllerBase
    {
        // GET: obtener directores
        [HttpGet]
        public ActionResult<IEnumerable<Director>> ObtenerDirectores()
        {
            return Ok();
        }

        [HttpGet("{idDirector}")]
        // GET: obtener director
        public ActionResult<Director> ObtenerDirector(Guid idDirector)
        {
            return Ok();
        }

        // POST: crear director
        [HttpPost]
        public ActionResult CrearDirector()
        {
            return Ok();
        }
    }
}
