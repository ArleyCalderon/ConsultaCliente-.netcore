using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultaInformacion.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "propietario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePropietario = table.Column<int>(type: "nvarchar(max)", maxLength: 50, nullable: false),
                    Cedula = table.Column<int>(type: "bigint", maxLength: 50, nullable: false),
                    Celular = table.Column<int>(type: "bigint", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propietario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propietario");
        }
    }
}
