using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPI.Data.Entities
{
    public class Pelicula
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Titulo { get; set; }

        [MaxLength(1000)]
        public string Sinopsis{ get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Anio { get; set; }

        [ForeignKey("IdDirector")]
        public Director Director { get; set; }

        public Guid IdDirector { get; set; }
        //fecha
    }
}
