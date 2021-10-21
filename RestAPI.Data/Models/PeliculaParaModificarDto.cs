using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Data.Models
{
    public class PeliculaParaModificarDto
    {

        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(1000)]
        public string Sinopsis { get; set; }

    }
}
