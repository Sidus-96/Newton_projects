using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class delete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructions_Plants_PlantId",
                table: "Instructions");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructions_Plants_PlantId",
                table: "Instructions",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructions_Plants_PlantId",
                table: "Instructions");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructions_Plants_PlantId",
                table: "Instructions",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
