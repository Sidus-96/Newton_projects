using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenThumb.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    plantId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_Plants_plantId",
                        column: x => x.plantId,
                        principalTable: "Plants",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Instruction", "Name", "plantId" },
                values: new object[,]
                {
                    { 1, "Vattna", "Lilja", null },
                    { 2, "VästLäge", "Lilja", null },
                    { 3, "Vattna lite sådär", "sommarväxt", null }
                });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lilja" },
                    { 2, "sommarväxt" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_plantId",
                table: "Instructions",
                column: "plantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropTable(
                name: "Plants");
        }
    }
}
