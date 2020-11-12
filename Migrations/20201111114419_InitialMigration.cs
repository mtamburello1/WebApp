using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autore",
                columns: table => new
                {
                    AutoreId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FotoAutore = table.Column<string>(nullable: true),
                    VideoAutore = table.Column<string>(nullable: true),
                    StoriaAutore = table.Column<string>(nullable: true),
                    NomeAutore = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autore", x => x.AutoreId);
                });

            migrationBuilder.CreateTable(
                name: "Opera",
                columns: table => new
                {
                    OperaId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutoreId = table.Column<long>(nullable: false),
                    Titolo = table.Column<string>(nullable: true),
                    Trama = table.Column<string>(nullable: true),
                    Contesto = table.Column<string>(nullable: true),
                    Prezzo = table.Column<float>(nullable: false),
                    VideoOpera = table.Column<string>(nullable: true),
                    FotoOpera = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opera", x => x.OperaId);
                    table.ForeignKey(
                        name: "FK_Opera_Autore_AutoreId",
                        column: x => x.AutoreId,
                        principalTable: "Autore",
                        principalColumn: "AutoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personaggio",
                columns: table => new
                {
                    PersonaggioId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperaId = table.Column<long>(nullable: false),
                    VideoPersonaggio = table.Column<string>(nullable: true),
                    TestoPersonaggio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaggio", x => x.PersonaggioId);
                    table.ForeignKey(
                        name: "FK_Personaggio_Opera_OperaId",
                        column: x => x.OperaId,
                        principalTable: "Opera",
                        principalColumn: "OperaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recensione",
                columns: table => new
                {
                    RecensioneId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValoreRecensione = table.Column<float>(nullable: false),
                    TestoRecensione = table.Column<string>(nullable: true),
                    OperaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recensione", x => x.RecensioneId);
                    table.ForeignKey(
                        name: "FK_Recensione_Opera_OperaId",
                        column: x => x.OperaId,
                        principalTable: "Opera",
                        principalColumn: "OperaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Opera_AutoreId",
                table: "Opera",
                column: "AutoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaggio_OperaId",
                table: "Personaggio",
                column: "OperaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recensione_OperaId",
                table: "Recensione",
                column: "OperaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personaggio");

            migrationBuilder.DropTable(
                name: "Recensione");

            migrationBuilder.DropTable(
                name: "Opera");

            migrationBuilder.DropTable(
                name: "Autore");
        }
    }
}
