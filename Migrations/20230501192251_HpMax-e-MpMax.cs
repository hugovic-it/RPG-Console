using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class HpMaxeMpMax : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HpMax",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MpMax",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HpMax",
                table: "Inimigos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MpMax",
                table: "Inimigos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HpMax",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "MpMax",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "HpMax",
                table: "Inimigos");

            migrationBuilder.DropColumn(
                name: "MpMax",
                table: "Inimigos");
        }
    }
}
