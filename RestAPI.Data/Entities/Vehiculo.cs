using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Data.Entities
{
    public class Vehiculo
    {
        public Vehiculo(int id, string marca, string anio, float precio)
        {
            ID = id;
            MARCA = marca;
            ANIO = anio;
            PRECIO = precio;
        }

        public int ID { get; set; }
        public string MARCA { get; set; }
        public string ANIO { get; set; }
        public float PRECIO { get; set; }
    }
}
