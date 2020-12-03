using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class update_entity_Vino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescrizioneVino",
                table: "Vino");

            migrationBuilder.AddColumn<string>(
                name: "CaratteristicheVino",
                table: "Vino",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoriaVino",
                table: "Vino",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CaratteristicheVino",
                table: "Vino");

            migrationBuilder.DropColumn(
                name: "StoriaVino",
                table: "Vino");

            migrationBuilder.AddColumn<string>(
                name: "DescrizioneVino",
                table: "Vino",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
