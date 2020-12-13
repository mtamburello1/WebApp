using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class AggioranemtoVini : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VinoNomeVino",
                table: "Zona",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VideoPersonaggio",
                table: "Personaggio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TestoPersonaggio",
                table: "Personaggio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NomePersonaggio",
                table: "Personaggio",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Zona_VinoNomeVino",
                table: "Zona",
                column: "VinoNomeVino");

            migrationBuilder.AddForeignKey(
                name: "FK_Zona_Vino_VinoNomeVino",
                table: "Zona",
                column: "VinoNomeVino",
                principalTable: "Vino",
                principalColumn: "NomeVino",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zona_Vino_VinoNomeVino",
                table: "Zona");

            migrationBuilder.DropIndex(
                name: "IX_Zona_VinoNomeVino",
                table: "Zona");

            migrationBuilder.DropColumn(
                name: "VinoNomeVino",
                table: "Zona");

            migrationBuilder.AlterColumn<string>(
                name: "VideoPersonaggio",
                table: "Personaggio",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TestoPersonaggio",
                table: "Personaggio",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomePersonaggio",
                table: "Personaggio",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
