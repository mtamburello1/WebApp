using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class update_entity_Vino_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provenienza_Vino_VinoId",
                table: "Provenienza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vino",
                table: "Vino");

            migrationBuilder.DropIndex(
                name: "IX_Provenienza_VinoId",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "VinoId",
                table: "Vino");

            migrationBuilder.AlterColumn<string>(
                name: "NomeVino",
                table: "Vino",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VinoNomeVino",
                table: "Provenienza",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vino",
                table: "Vino",
                column: "NomeVino");

            migrationBuilder.CreateIndex(
                name: "IX_Provenienza_VinoNomeVino",
                table: "Provenienza",
                column: "VinoNomeVino");

            migrationBuilder.AddForeignKey(
                name: "FK_Provenienza_Vino_VinoNomeVino",
                table: "Provenienza",
                column: "VinoNomeVino",
                principalTable: "Vino",
                principalColumn: "NomeVino",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provenienza_Vino_VinoNomeVino",
                table: "Provenienza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vino",
                table: "Vino");

            migrationBuilder.DropIndex(
                name: "IX_Provenienza_VinoNomeVino",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "VinoNomeVino",
                table: "Provenienza");

            migrationBuilder.AlterColumn<string>(
                name: "NomeVino",
                table: "Vino",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<long>(
                name: "VinoId",
                table: "Vino",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vino",
                table: "Vino",
                column: "VinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Provenienza_VinoId",
                table: "Provenienza",
                column: "VinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provenienza_Vino_VinoId",
                table: "Provenienza",
                column: "VinoId",
                principalTable: "Vino",
                principalColumn: "VinoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
