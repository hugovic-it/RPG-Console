using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace rpg_console.Migrations
{
    /// <inheritdoc />
    public partial class segundamigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmaEquipamentoArmaId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Defesa",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Forca",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mp",
                table: "Jogadores",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defesa",
                table: "Inimigos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Forca",
                table: "Inimigos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mp",
                table: "Inimigos",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Arma",
                columns: table => new
                {
                    EquipamentoArmaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arma", x => x.EquipamentoArmaId);
                });

            migrationBuilder.CreateTable(
                name: "Armadura",
                columns: table => new
                {
                    EquipamentoArmaduraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armadura", x => x.EquipamentoArmaduraId);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    JogadorId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogadores",
                        principalColumn: "JogadorId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores",
                column: "ArmaduraEquipamentoArmaduraId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_ArmaEquipamentoArmaId",
                table: "Jogadores",
                column: "ArmaEquipamentoArmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_JogadorId",
                table: "Item",
                column: "JogadorId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Arma_ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armadura_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.DropTable(
                name: "Arma");

            migrationBuilder.DropTable(
                name: "Armadura");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_ArmaduraEquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "ArmaEquipamentoArmaId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "ArmaduraEquipamentoArmaduraId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Forca",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Mp",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Defesa",
                table: "Inimigos");

            migrationBuilder.DropColumn(
                name: "Forca",
                table: "Inimigos");

            migrationBuilder.DropColumn(
                name: "Mp",
                table: "Inimigos");
        }
    }
}
