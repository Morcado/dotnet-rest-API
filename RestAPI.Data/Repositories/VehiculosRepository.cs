using RestAPI.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI.Data.Repositories
{
    public class VehiculosRepository : IVehiculosRepository
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>()
        {
            new Vehiculo(1, "NISSAN", "2007", 400.00f),
            new Vehiculo(2, "CHEVY", "2012", 2000.00f),
            new Vehiculo(3, "FORD", "2023", 100.00f),
            new Vehiculo(4, "BMW", "2010", 4500.00f),
        };
        public Vehiculo ObtenerVehiculo(int id)
        {
            return vehiculos.Where(v => v.ID == id).FirstOrDefault();
        }

        public IEnumerable<Vehiculo> ObtenerVehiculos()
        {
            return vehiculos;
        }
    }
}
