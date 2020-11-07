using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiExamenAngulaNet.Migrations
{
    public partial class AngularNet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    IdEntrada = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.IdEntrada);
                });

            migrationBuilder.CreateTable(
                name: "Estadio",
                columns: table => new
                {
                    IdEstadio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CapacidadTotal = table.Column<int>(type: "int", nullable: false),
                    Porcentaje = table.Column<int>(type: "int", nullable: false),
                    CapacidadPermitida = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadio", x => x.IdEstadio);
                });

            migrationBuilder.CreateTable(
                name: "Hincha",
                columns: table => new
                {
                    IdHincha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hincha", x => x.IdHincha);
                });

            migrationBuilder.CreateTable(
                name: "ControlEntrada",
                columns: table => new
                {
                    IdControl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntradaSalida = table.Column<int>(type: "int", nullable: false),
                    IdHincha = table.Column<int>(type: "int", nullable: false),
                    Asiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEntrada = table.Column<int>(type: "int", nullable: false),
                    EstadioIdEstadio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlEntrada", x => x.IdControl);
                    table.ForeignKey(
                        name: "FK_ControlEntrada_Estadio_EstadioIdEstadio",
                        column: x => x.EstadioIdEstadio,
                        principalTable: "Estadio",
                        principalColumn: "IdEstadio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlEntrada_EstadioIdEstadio",
                table: "ControlEntrada",
                column: "EstadioIdEstadio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlEntrada");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Hincha");

            migrationBuilder.DropTable(
                name: "Estadio");
        }
    }
}
