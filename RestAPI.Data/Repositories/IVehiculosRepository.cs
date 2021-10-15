using RestAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Data.Repositories
{
    public interface IVehiculosRepository
    {
        IEnumerable<Vehiculo> ObtenerVehiculos();
        Vehiculo ObtenerVehiculo(int id);
    }
}
