using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class ajustesArmaEArmadura : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ataque",
                table: "Armadura");

            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Arma");

            migrationBuilder.AddColumn<int>(
                name: "Defesa",
                table: "Armadura",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ataque",
                table: "Arma",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Armadura");

            migrationBuilder.DropColumn(
                name: "Ataque",
                table: "Arma");

            migrationBuilder.AddColumn<string>(
                name: "Ataque",
                table: "Armadura",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Defesa",
                table: "Arma",
                type: "TEXT",
                nullable: true);
        }
    }
}
