using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kolokwium_s22884.Migrations
{
    /// <inheritdoc />
    public partial class AddCharacterTitlesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters_Titles",
                columns: table => new
                {
                    FK_charact = table.Column<int>(type: "int", nullable: false),
                    FK_title = table.Column<int>(type: "int", nullable: false),
                    aquire_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters_Titles", x => new { x.FK_charact, x.FK_title });
                    table.ForeignKey(
                        name: "FK_Characters_Titles_Characters_FK_charact",
                        column: x => x.FK_charact,
                        principalTable: "Characters",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Titles_Titles_FK_title",
                        column: x => x.FK_title,
                        principalTable: "Titles",
                        principalColumn: "PK",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_Titles_FK_title",
                table: "Characters_Titles",
                column: "FK_title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters_Titles");
        }
    }
}
