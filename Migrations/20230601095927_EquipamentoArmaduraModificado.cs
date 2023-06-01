using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class EquipamentoArmaduraModificado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armaduras_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.RenameColumn(
                name: "ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                newName: "EquipamentoArmaduraId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogadores_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                newName: "IX_Jogadores_EquipamentoArmaduraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armaduras_EquipamentoArmaduraId",
                table: "Jogadores",
                column: "EquipamentoArmaduraId",
                principalTable: "Armaduras",
                principalColumn: "EquipamentoArmaduraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armaduras_EquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.RenameColumn(
                name: "EquipamentoArmaduraId",
                table: "Jogadores",
                newName: "ArmaduraEquipamentoArmaduraId");

            migrationBuilder.RenameIndex(
                name: "IX_Jogadores_EquipamentoArmaduraId",
                table: "Jogadores",
                newName: "IX_Jogadores_ArmaduraEquipamentoArmaduraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armaduras_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                column: "ArmaduraEquipamentoArmaduraId",
                principalTable: "Armaduras",
                principalColumn: "EquipamentoArmaduraId");
        }
    }
}
