using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class NumberOfStarsInOpera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FiveStars",
                table: "Opera",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FourStars",
                table: "Opera",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OneStars",
                table: "Opera",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThreeStars",
                table: "Opera",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TwoStars",
                table: "Opera",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FiveStars",
                table: "Opera");

            migrationBuilder.DropColumn(
                name: "FourStars",
                table: "Opera");

            migrationBuilder.DropColumn(
                name: "OneStars",
                table: "Opera");

            migrationBuilder.DropColumn(
                name: "ThreeStars",
                table: "Opera");

            migrationBuilder.DropColumn(
                name: "TwoStars",
                table: "Opera");
        }
    }
}
