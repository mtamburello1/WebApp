using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class update_entity_Provenienza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VinoId",
                table: "Provenienza");

            migrationBuilder.AddColumn<string>(
                name: "NomeVino",
                table: "Provenienza",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomeVino",
                table: "Provenienza");

            migrationBuilder.AddColumn<long>(
                name: "VinoId",
                table: "Provenienza",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
