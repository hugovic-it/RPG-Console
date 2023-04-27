using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class ajustesmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Experiencia",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Item",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Experiencia",
                table: "Inimigos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ataque",
                table: "Armadura",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Armadura",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Defesa",
                table: "Arma",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Arma",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experiencia",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Experiencia",
                table: "Inimigos");

            migrationBuilder.DropColumn(
                name: "Ataque",
                table: "Armadura");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Armadura");

            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Arma");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Arma");
        }
    }
}
