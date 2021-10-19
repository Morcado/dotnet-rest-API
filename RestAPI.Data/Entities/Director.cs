using System;
using System.ComponentModel.DataAnnotations;

namespace RestAPI.Data.Entities
{
    public class Director
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }


        public int Premios { get; set; }

    }
}
