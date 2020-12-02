using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.Migrations
{
    public partial class update_entities_Bianco_e_Nero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vino_Zone_Provenienza_Zone_ProvenienzaZonaId",
                table: "Vino");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zone_Provenienza",
                table: "Zone_Provenienza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vino",
                table: "Vino");

            migrationBuilder.DropIndex(
                name: "IX_Vino_Zone_ProvenienzaZonaId",
                table: "Vino");

            migrationBuilder.DropColumn(
                name: "ZonaId",
                table: "Zone_Provenienza");

            migrationBuilder.DropColumn(
                name: "VinoId",
                table: "Vino");

            migrationBuilder.DropColumn(
                name: "Zone_ProvenienzaZonaId",
                table: "Vino");

            migrationBuilder.DropColumn(
                name: "VinoId",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "ZonaId",
                table: "Provenienza");

            migrationBuilder.AlterColumn<string>(
                name: "NomeZona",
                table: "Zone_Provenienza",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeVino",
                table: "Vino",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Zone_ProvenienzaNomeZona",
                table: "Vino",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "NomeVino",
                table: "Provenienza",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "NomeZona",
                table: "Provenienza",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "VinoNomeVino",
                table: "Provenienza",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ZonaNomeZona",
                table: "Provenienza",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zone_Provenienza",
                table: "Zone_Provenienza",
                column: "NomeZona");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vino",
                table: "Vino",
                column: "NomeVino");

            migrationBuilder.CreateIndex(
                name: "IX_Vino_Zone_ProvenienzaNomeZona",
                table: "Vino",
                column: "Zone_ProvenienzaNomeZona");

            migrationBuilder.CreateIndex(
                name: "IX_Provenienza_VinoNomeVino",
                table: "Provenienza",
                column: "VinoNomeVino");

            migrationBuilder.CreateIndex(
                name: "IX_Provenienza_ZonaNomeZona",
                table: "Provenienza",
                column: "ZonaNomeZona");

            migrationBuilder.AddForeignKey(
                name: "FK_Provenienza_Vino_VinoNomeVino",
                table: "Provenienza",
                column: "VinoNomeVino",
                principalTable: "Vino",
                principalColumn: "NomeVino",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Provenienza_Zone_Provenienza_ZonaNomeZona",
                table: "Provenienza",
                column: "ZonaNomeZona",
                principalTable: "Zone_Provenienza",
                principalColumn: "NomeZona",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vino_Zone_Provenienza_Zone_ProvenienzaNomeZona",
                table: "Vino",
                column: "Zone_ProvenienzaNomeZona",
                principalTable: "Zone_Provenienza",
                principalColumn: "NomeZona",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provenienza_Vino_VinoNomeVino",
                table: "Provenienza");

            migrationBuilder.DropForeignKey(
                name: "FK_Provenienza_Zone_Provenienza_ZonaNomeZona",
                table: "Provenienza");

            migrationBuilder.DropForeignKey(
                name: "FK_Vino_Zone_Provenienza_Zone_ProvenienzaNomeZona",
                table: "Vino");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zone_Provenienza",
                table: "Zone_Provenienza");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vino",
                table: "Vino");

            migrationBuilder.DropIndex(
                name: "IX_Vino_Zone_ProvenienzaNomeZona",
                table: "Vino");

            migrationBuilder.DropIndex(
                name: "IX_Provenienza_VinoNomeVino",
                table: "Provenienza");

            migrationBuilder.DropIndex(
                name: "IX_Provenienza_ZonaNomeZona",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "Zone_ProvenienzaNomeZona",
                table: "Vino");

            migrationBuilder.DropColumn(
                name: "NomeVino",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "NomeZona",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "VinoNomeVino",
                table: "Provenienza");

            migrationBuilder.DropColumn(
                name: "ZonaNomeZona",
                table: "Provenienza");

            migrationBuilder.AlterColumn<string>(
                name: "NomeZona",
                table: "Zone_Provenienza",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<long>(
                name: "ZonaId",
                table: "Zone_Provenienza",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.AddColumn<long>(
                name: "Zone_ProvenienzaZonaId",
                table: "Vino",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VinoId",
                table: "Provenienza",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ZonaId",
                table: "Provenienza",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zone_Provenienza",
                table: "Zone_Provenienza",
                column: "ZonaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vino",
                table: "Vino",
                column: "VinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vino_Zone_ProvenienzaZonaId",
                table: "Vino",
                column: "Zone_ProvenienzaZonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vino_Zone_Provenienza_Zone_ProvenienzaZonaId",
                table: "Vino",
                column: "Zone_ProvenienzaZonaId",
                principalTable: "Zone_Provenienza",
                principalColumn: "ZonaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
