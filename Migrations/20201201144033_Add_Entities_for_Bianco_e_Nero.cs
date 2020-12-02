using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class Add_Entities_for_Bianco_e_Nero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provenienza",
                columns: table => new
                {
                    ProvenienzaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZonaId = table.Column<long>(nullable: false),
                    VinoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provenienza", x => x.ProvenienzaId);
                });

            migrationBuilder.CreateTable(
                name: "Zone_Provenienza",
                columns: table => new
                {
                    ZonaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeZona = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zone_Provenienza", x => x.ZonaId);
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
                    Zone_ProvenienzaZonaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vino", x => x.VinoId);
                    table.ForeignKey(
                        name: "FK_Vino_Zone_Provenienza_Zone_ProvenienzaZonaId",
                        column: x => x.Zone_ProvenienzaZonaId,
                        principalTable: "Zone_Provenienza",
                        principalColumn: "ZonaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vino_Zone_ProvenienzaZonaId",
                table: "Vino",
                column: "Zone_ProvenienzaZonaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Provenienza");

            migrationBuilder.DropTable(
                name: "Vino");

            migrationBuilder.DropTable(
                name: "Zone_Provenienza");
        }
    }
}
