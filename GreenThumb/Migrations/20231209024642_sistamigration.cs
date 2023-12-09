using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class sistamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Garden",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[] { 1, "0TKNGWAGpMrAJWfvP5Jdmg==", "admin" });

            migrationBuilder.InsertData(
                table: "Garden",
                columns: new[] { "Id", "PlantId", "UserId" },
                values: new object[] { 1, null, 1 });
        }
    }
}
