// <auto-generated />
using System;
using CourseLibrary.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RestAPI.Data.Migrations
{
    [DbContext(typeof(CineContext))]
    [Migration("20211019033704_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestAPI.Data.Entities.Director", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Premios")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Directores");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Apellido = "Bruckner",
                            Nombre = "David",
                            Premios = 1
                        },
                        new
                        {
                            Id = new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                            Apellido = "Nolan",
                            Nombre = "Christopher",
                            Premios = 139
                        });
                });

            modelBuilder.Entity("RestAPI.Data.Entities.Pelicula", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdDirector")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Sinopsis")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdDirector");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("385a50ef-b556-4921-9dff-34b7983dfdad"),
                            Anio = "2020",
                            Genero = "Horror",
                            IdDirector = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Sinopsis = "Una viuda comienza a descubrir los inquietantes secretos de su marido recientemente fallecido.",
                            Titulo = "La casa oscura"
                        },
                        new
                        {
                            Id = new Guid("137a8e12-369c-41cf-8fca-f6f211fe9214"),
                            Anio = "2017",
                            Genero = "Horror",
                            IdDirector = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Sinopsis = "Un grupo de viejos amigos de la universidad se reúne para hacer un viaje a un bosque en Suecia, pero se encuentra con una presencia amenazante que los acecha.",
                            Titulo = "El ritual"
                        },
                        new
                        {
                            Id = new Guid("789fb065-8231-4200-8e43-13946dc5fba5"),
                            Anio = "2015",
                            Genero = "Horror",
                            IdDirector = new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"),
                            Sinopsis = "Cinco relatos de horror entrecruzados siguen los caminos de un grupo de viajeros cansados que se enfrentan a sus peores pesadillas durante una larga noche en un trecho desolado de una autopista en el desierto.",
                            Titulo = "Southbound"
                        },
                        new
                        {
                            Id = new Guid("4939ff04-4700-4b20-9e8a-fd117ff9fb1d"),
                            Anio = "2010",
                            Genero = "Ciencia ficción",
                            IdDirector = new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                            Sinopsis = "A un ladrón que roba secretos corporativos a través del uso de la tecnología de compartir sueños, se le da la tarea de implantar una idea en la mente de un jefe de una gran empresa.",
                            Titulo = "Inception"
                        },
                        new
                        {
                            Id = new Guid("8daf81ba-efff-4642-82ba-f772ede5234e"),
                            Anio = "2014",
                            Genero = "Ciencia ficción",
                            IdDirector = new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                            Sinopsis = "Un equipo de exploradores viaja a través de un agujero de gusano en el espacio en un intento de garantizar la supervivencia de la humanidad.",
                            Titulo = "Interestelar"
                        },
                        new
                        {
                            Id = new Guid("2900022a-eeb3-4669-b090-546cd288fe8e"),
                            Anio = "2012",
                            Genero = "Accion",
                            IdDirector = new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                            Sinopsis = "Ocho años después del reinado de anarquía del Joker, Batman, con la ayuda de la enigmática Catwoman, se ve obligado a salir de su exilio para salvar a Gotham City del brutal terrorista guerrillero Bane.",
                            Titulo = "Batman: El caballero de la noche asciende"
                        },
                        new
                        {
                            Id = new Guid("76d73e16-459e-402d-8b9d-4a91bf5cc829"),
                            Anio = "2000",
                            Genero = "Misterio",
                            IdDirector = new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"),
                            Sinopsis = "Un hombre con pérdida de memoria a corto plazo intenta encontrar al asesino de su esposa.",
                            Titulo = "Memento"
                        });
                });

            modelBuilder.Entity("RestAPI.Data.Entities.Pelicula", b =>
                {
                    b.HasOne("RestAPI.Data.Entities.Director", "Director")
                        .WithMany()
                        .HasForeignKey("IdDirector")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });
#pragma warning restore 612, 618
        }
    }
}
