using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class RelacionamentoNoJogador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armas_ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.AddColumn<int>(
                name: "EquipamentoArmaId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.AddColumn<int>(
                name: "ArmaEquipamentoArmaId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_ArmaEquipamentoArmaId",
                table: "Jogadores",
                column: "ArmaEquipamentoArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armas_ArmaEquipamentoArmaId",
                table: "Jogadores",
                column: "ArmaEquipamentoArmaId",
                principalTable: "Armas",
                principalColumn: "EquipamentoArmaId");
        }
    }
}
