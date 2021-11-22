using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.Migrations
{
    public partial class primero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubId);
                });

            migrationBuilder.CreateTable(
                name: "Actividades",
                columns: table => new
                {
                    ActividadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(nullable: false),
                    HorarioInicio = table.Column<int>(nullable: false),
                    HorarioFinal = table.Column<int>(nullable: false),
                    ClubId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividades", x => x.ActividadId);
                    table.ForeignKey(
                        name: "FK_Actividades_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Precio = table.Column<double>(nullable: false),
                    ClubId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.PlanId);
                    table.ForeignKey(
                        name: "FK_Planes_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    SocioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Domicilio = table.Column<string>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    ClubId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.SocioId);
                    table.ForeignKey(
                        name: "FK_Socios_Clubs_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Socios_Clubs_ClubId1",
                        column: x => x.ClubId1,
                        principalTable: "Clubs",
                        principalColumn: "ClubId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividades_ClubId",
                table: "Actividades",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_ClubId",
                table: "Planes",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_ClubId",
                table: "Socios",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_Socios_ClubId1",
                table: "Socios",
                column: "ClubId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividades");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Socios");

            migrationBuilder.DropTable(
                name: "Clubs");
        }
    }
}
