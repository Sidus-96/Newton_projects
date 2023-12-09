using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class createGardenUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PLantId",
                table: "Garden",
                newName: "PlantId");

            migrationBuilder.InsertData(
                table: "Garden",
                columns: new[] { "Id", "PlantId", "UserId" },
                values: new object[] { 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "0TKNGWAGpMrAJWfvP5Jdmg==");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Garden",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "PlantId",
                table: "Garden",
                newName: "PLantId");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "0TKNGWAGpMrAJWfvP5Jdmg==");
        }
    }
}
