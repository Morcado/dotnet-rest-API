using Microsoft.AspNetCore.Mvc;
using RestAPI.Data.Entities;
using RestAPI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.API.Controllers
{
    [Route("vehiculos")]
    public class VehiculosController : ControllerBase
    {
        private readonly IVehiculosRepository _vehiculosRepository;

        public VehiculosController(IVehiculosRepository vehiculosRepository)
        {
            _vehiculosRepository = vehiculosRepository;
        }
        // GET vehiculos
        [HttpGet]
        public ActionResult<Vehiculo> Index()
        {
            var vehiculos = _vehiculosRepository.ObtenerVehiculos();
            return Ok(vehiculos);
        }

        // GET vehiculo
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Vehiculo>> ObtenerVehiculo(int id)
        {
            var vehiculo = _vehiculosRepository.ObtenerVehiculo(id);
            if (vehiculo == null)
            {
                return NotFound();
            }
            return Ok(vehiculo);
        }

    }
}
