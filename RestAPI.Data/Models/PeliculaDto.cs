using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Data.Models
{
    public class PeliculaDto
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Sinopsis { get; set; }

        public string Genero { get; set; }

        public string Anio { get; set; }

        public Guid IdDirector { get; set; }
    }
}
