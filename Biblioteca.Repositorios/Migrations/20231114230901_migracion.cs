using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Repositorios.Migrations
{
    /// <inheritdoc />
    public partial class migracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Autor = table.Column<string>(type: "TEXT", nullable: false),
                    AñoPublicacion = table.Column<int>(type: "INTEGER", nullable: false),
                    genero = table.Column<string>(type: "TEXT", nullable: false),
                    CantEjemplares = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumCarnet = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Apellido = table.Column<string>(type: "TEXT", nullable: false),
                    Direccion = table.Column<string>(type: "TEXT", nullable: false),
                    Facultad = table.Column<string>(type: "TEXT", nullable: false),
                    Telefono = table.Column<int>(type: "INTEGER", nullable: false),
                    Correo = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    NumMatricula = table.Column<int>(type: "INTEGER", nullable: true),
                    AñoInicio = table.Column<int>(type: "INTEGER", nullable: true),
                    NumAlumno = table.Column<int>(type: "INTEGER", nullable: true),
                    Carrera = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Idpersona = table.Column<int>(type: "INTEGER", nullable: false),
                    Idlibro = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPrestamo = table.Column<string>(type: "TEXT", nullable: false),
                    FechaDevolucion = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_Idlibro",
                        column: x => x.Idlibro,
                        principalTable: "Libros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Persona_Idpersona",
                        column: x => x.Idpersona,
                        principalTable: "Persona",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_Idlibro",
                table: "Prestamos",
                column: "Idlibro");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_Idpersona",
                table: "Prestamos",
                column: "Idpersona");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
