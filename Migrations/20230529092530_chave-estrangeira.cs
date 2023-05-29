using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class chaveestrangeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_EquipamentoArmaId",
                table: "Jogadores",
                column: "EquipamentoArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armas_EquipamentoArmaId",
                table: "Jogadores",
                column: "EquipamentoArmaId",
                principalTable: "Armas",
                principalColumn: "EquipamentoArmaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armas_EquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_EquipamentoArmaId",
                table: "Jogadores");
        }
    }
}
