using System;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Data.Models
{
    public class PeliculaParaCrearDto
    {

        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(1000)]
        public string Sinopsis { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Anio { get; set; }
    }
}
