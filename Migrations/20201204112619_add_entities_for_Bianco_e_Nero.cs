using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class add_entities_for_Bianco_e_Nero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vino",
                columns: table => new
                {
                    NomeVino = table.Column<string>(nullable: false),
                    StoriaVino = table.Column<string>(nullable: true),
                    CaratteristicheVino = table.Column<string>(nullable: true),
                    TipoVino = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vino", x => x.NomeVino);
                });

            migrationBuilder.CreateTable(
                name: "Zona",
                columns: table => new
                {
                    NomeZona = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zona", x => x.NomeZona);
                });

            migrationBuilder.CreateTable(
                name: "ZonaVino",
                columns: table => new
                {
                    NomeVino = table.Column<string>(nullable: false),
                    NomeZona = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZonaVino", x => new { x.NomeZona, x.NomeVino });
                    table.ForeignKey(
                        name: "FK_ZonaVino_Vino_NomeVino",
                        column: x => x.NomeVino,
                        principalTable: "Vino",
                        principalColumn: "NomeVino",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ZonaVino_Zona_NomeZona",
                        column: x => x.NomeZona,
                        principalTable: "Zona",
                        principalColumn: "NomeZona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ZonaVino_NomeVino",
                table: "ZonaVino",
                column: "NomeVino");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ZonaVino");

            migrationBuilder.DropTable(
                name: "Vino");

            migrationBuilder.DropTable(
                name: "Zona");
        }
    }
}
