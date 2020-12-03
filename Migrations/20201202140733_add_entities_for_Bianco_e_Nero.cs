using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class add_entities_for_Bianco_e_Nero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Vino",
                columns: table => new
                {
                    VinoId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeVino = table.Column<string>(nullable: true),
                    DescrizioneVino = table.Column<string>(nullable: true),
                    TipoVino = table.Column<string>(nullable: true),
                    ZonaNomeZona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vino", x => x.VinoId);
                    table.ForeignKey(
                        name: "FK_Vino_Zona_ZonaNomeZona",
                        column: x => x.ZonaNomeZona,
                        principalTable: "Zona",
                        principalColumn: "NomeZona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provenienza",
                columns: table => new
                {
                    ProvenienzaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeZona = table.Column<string>(nullable: true),
                    VinoId = table.Column<long>(nullable: false),
                    ZonaNomeZona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provenienza", x => x.ProvenienzaId);
                    table.ForeignKey(
                        name: "FK_Provenienza_Vino_VinoId",
                        column: x => x.VinoId,
                        principalTable: "Vino",
                        principalColumn: "VinoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Provenienza_Zona_ZonaNomeZona",
                        column: x => x.ZonaNomeZona,
                        principalTable: "Zona",
                        principalColumn: "NomeZona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provenienza_VinoId",
                table: "Provenienza",
                column: "VinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provenienza_ZonaNomeZona",
                table: "Provenienza",
                column: "ZonaNomeZona");

            migrationBuilder.CreateIndex(
                name: "IX_Vino_ZonaNomeZona",
                table: "Vino",
                column: "ZonaNomeZona");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provenienza");

            migrationBuilder.DropTable(
                name: "Vino");

            migrationBuilder.DropTable(
                name: "Zona");
        }
    }
}
