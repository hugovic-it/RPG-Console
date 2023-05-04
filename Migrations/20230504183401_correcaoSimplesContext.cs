using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class correcaoSimplesContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Arma_ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armadura_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Armadura",
                table: "Armadura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arma",
                table: "Arma");

            migrationBuilder.RenameTable(
                name: "Armadura",
                newName: "Armaduras");

            migrationBuilder.RenameTable(
                name: "Arma",
                newName: "Armas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Armaduras",
                table: "Armaduras",
                column: "EquipamentoArmaduraId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Armas",
                table: "Armas",
                column: "EquipamentoArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armaduras_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                column: "ArmaduraEquipamentoArmaduraId",
                principalTable: "Armaduras",
                principalColumn: "EquipamentoArmaduraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armas_ArmaEquipamentoArmaId",
                table: "Jogadores",
                column: "ArmaEquipamentoArmaId",
                principalTable: "Armas",
                principalColumn: "EquipamentoArmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armaduras_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armas_ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Armas",
                table: "Armas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Armaduras",
                table: "Armaduras");

            migrationBuilder.RenameTable(
                name: "Armas",
                newName: "Arma");

            migrationBuilder.RenameTable(
                name: "Armaduras",
                newName: "Armadura");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arma",
                table: "Arma",
                column: "EquipamentoArmaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Armadura",
                table: "Armadura",
                column: "EquipamentoArmaduraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Arma_ArmaEquipamentoArmaId",
                table: "Jogadores",
                column: "ArmaEquipamentoArmaId",
                principalTable: "Arma",
                principalColumn: "EquipamentoArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armadura_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                column: "ArmaduraEquipamentoArmaduraId",
                principalTable: "Armadura",
                principalColumn: "EquipamentoArmaduraId");
        }
    }
}
