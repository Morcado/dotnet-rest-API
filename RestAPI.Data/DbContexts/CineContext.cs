using Microsoft.EntityFrameworkCore;
using RestAPI.Data.Entities;
using System;

namespace CourseLibrary.API.DbContexts
{
    public class CineContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Server=(localdb)\mssqllocaldb;Database=CineDB;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Director> Directores { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Director>().HasData(
                new Director() {
                    Id = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Nombre = "David",
                    Apellido = "Bruckner",
                    Premios = 1
                },
                new Director() {
                    Id = Guid.Parse("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                    Nombre = "Christopher",
                    Apellido = "Nolan",
                    Premios = 139
                }
            );
            modelBuilder.Entity<Pelicula>().HasData(
                new Pelicula()
                {
                    Id = Guid.Parse("385a50ef-b556-4921-9dff-34b7983dfdad"),
                    IdDirector = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Titulo = "La casa oscura",
                    Genero = "Horror",
                    Anio = "2020",
                    Sinopsis = "Una viuda comienza a descubrir los inquietantes secretos de su marido recientemente fallecido."
                },
                new Pelicula()
                {
                    Id = Guid.Parse("137a8e12-369c-41cf-8fca-f6f211fe9214"),
                    IdDirector = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Titulo = "El ritual",
                    Genero = "Horror",
                    Anio = "2017",
                    Sinopsis = "Un grupo de viejos amigos de la universidad se reúne para hacer un viaje a un bosque en Suecia, pero se encuentra con una presencia amenazante que los acecha."
                },
                new Pelicula()
                {
                    Id = Guid.Parse("789fb065-8231-4200-8e43-13946dc5fba5"),
                    IdDirector = Guid.Parse("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                    Titulo = "Southbound",
                    Genero = "Horror",
                    Anio = "2015",
                    Sinopsis = "Cinco relatos de horror entrecruzados siguen los caminos de un grupo de viajeros cansados que se enfrentan a sus peores pesadillas durante una larga noche en un trecho desolado de una autopista en el desierto."
                },
                new Pelicula()
                {
                    Id = Guid.Parse("4939ff04-4700-4b20-9e8a-fd117ff9fb1d"),
                    IdDirector = Guid.Parse("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                    Titulo = "Inception",
                    Genero = "Ciencia ficción",
                    Anio = "2010",
                    Sinopsis = "A un ladrón que roba secretos corporativos a través del uso de la tecnología de compartir sueños, se le da la tarea de implantar una idea en la mente de un jefe de una gran empresa."
                },
                new Pelicula()
                {
                    Id = Guid.Parse("8daf81ba-efff-4642-82ba-f772ede5234e"),
                    IdDirector = Guid.Parse("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                    Titulo = "Interestelar",
                    Genero = "Ciencia ficción",
                    Anio = "2014",
                    Sinopsis = "Un equipo de exploradores viaja a través de un agujero de gusano en el espacio en un intento de garantizar la supervivencia de la humanidad."
                },
                new Pelicula()
                {
                    Id = Guid.Parse("2900022a-eeb3-4669-b090-546cd288fe8e"),
                    IdDirector = Guid.Parse("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                    Titulo = "Batman: El caballero de la noche asciende",
                    Genero = "Accion",
                    Anio = "2012",
                    Sinopsis = "Ocho años después del reinado de anarquía del Joker, Batman, con la ayuda de la enigmática Catwoman, se ve obligado a salir de su exilio para salvar a Gotham City del brutal terrorista guerrillero Bane."
                },
                new Pelicula()
                {
                    Id = Guid.Parse("76d73e16-459e-402d-8b9d-4a91bf5cc829"),
                    IdDirector = Guid.Parse("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                    Titulo = "Memento",
                    Genero = "Misterio",
                    Anio = "2000",
                    Sinopsis = "Un hombre con pérdida de memoria a corto plazo intenta encontrar al asesino de su esposa."
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
