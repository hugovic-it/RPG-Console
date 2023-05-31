using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class CorrecaoArmaFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armas_EquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.AlterColumn<int>(
                name: "EquipamentoArmaId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armas_EquipamentoArmaId",
                table: "Jogadores",
                column: "EquipamentoArmaId",
                principalTable: "Armas",
                principalColumn: "EquipamentoArmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armas_EquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.AlterColumn<int>(
                name: "EquipamentoArmaId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armas_EquipamentoArmaId",
                table: "Jogadores",
                column: "EquipamentoArmaId",
                principalTable: "Armas",
                principalColumn: "EquipamentoArmaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
