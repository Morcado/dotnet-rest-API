using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestAPI.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Premios = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directores", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDirector = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peliculas_Directores_IdDirector",
                        column: x => x.IdDirector,
                        principalTable: "Directores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directores",
                columns: new[] { "Id", "Apellido", "Nombre", "Premios" },
                values: new object[] { new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Bruckner", "David", 1 });

            migrationBuilder.InsertData(
                table: "Directores",
                columns: new[] { "Id", "Apellido", "Nombre", "Premios" },
                values: new object[] { new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"), "Nolan", "Christopher", 139 });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "Id", "Anio", "Genero", "IdDirector", "Sinopsis", "Titulo" },
                values: new object[,]
                {
                    { new Guid("385a50ef-b556-4921-9dff-34b7983dfdad"), "2020", "Horror", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Una viuda comienza a descubrir los inquietantes secretos de su marido recientemente fallecido.", "La casa oscura" },
                    { new Guid("137a8e12-369c-41cf-8fca-f6f211fe9214"), "2017", "Horror", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Un grupo de viejos amigos de la universidad se reúne para hacer un viaje a un bosque en Suecia, pero se encuentra con una presencia amenazante que los acecha.", "El ritual" },
                    { new Guid("789fb065-8231-4200-8e43-13946dc5fba5"), "2015", "Horror", new Guid("d28888e9-2ba9-473a-a40f-e38cb54f9b35"), "Cinco relatos de horror entrecruzados siguen los caminos de un grupo de viajeros cansados que se enfrentan a sus peores pesadillas durante una larga noche en un trecho desolado de una autopista en el desierto.", "Southbound" },
                    { new Guid("4939ff04-4700-4b20-9e8a-fd117ff9fb1d"), "2010", "Ciencia ficción", new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"), "A un ladrón que roba secretos corporativos a través del uso de la tecnología de compartir sueños, se le da la tarea de implantar una idea en la mente de un jefe de una gran empresa.", "Inception" },
                    { new Guid("8daf81ba-efff-4642-82ba-f772ede5234e"), "2014", "Ciencia ficción", new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"), "Un equipo de exploradores viaja a través de un agujero de gusano en el espacio en un intento de garantizar la supervivencia de la humanidad.", "Interestelar" },
                    { new Guid("2900022a-eeb3-4669-b090-546cd288fe8e"), "2012", "Accion", new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"), "Ocho años después del reinado de anarquía del Joker, Batman, con la ayuda de la enigmática Catwoman, se ve obligado a salir de su exilio para salvar a Gotham City del brutal terrorista guerrillero Bane.", "Batman: El caballero de la noche asciende" },
                    { new Guid("76d73e16-459e-402d-8b9d-4a91bf5cc829"), "2000", "Misterio", new Guid("4a55319b-282a-4afb-b891-7dc460b6cafa"), "Un hombre con pérdida de memoria a corto plazo intenta encontrar al asesino de su esposa.", "Memento" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_IdDirector",
                table: "Peliculas",
                column: "IdDirector");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Directores");
        }
    }
}
