using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium_s22884.Migrations
{
    /// <inheritdoc />
    public partial class AddBackpackTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BackPack_Slots",
                columns: table => new
                {
                    PK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_item = table.Column<int>(type: "int", nullable: false),
                    Fk_character = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BackPack_Slots", x => x.PK);
                    table.ForeignKey(
                        name: "FK_BackPack_Slots_Characters_Fk_character",
                        column: x => x.Fk_character,
                        principalTable: "Characters",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BackPack_Slots_Items_Fk_item",
                        column: x => x.Fk_item,
                        principalTable: "Items",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BackPack_Slots_Fk_character",
                table: "BackPack_Slots",
                column: "Fk_character");

            migrationBuilder.CreateIndex(
                name: "IX_BackPack_Slots_Fk_item",
                table: "BackPack_Slots",
                column: "Fk_item");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BackPack_Slots");
        }
    }
}
