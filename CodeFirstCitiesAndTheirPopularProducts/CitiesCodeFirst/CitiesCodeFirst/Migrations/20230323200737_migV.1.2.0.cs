using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CitiesCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class migV120 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "PopularProducts",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopularProducts", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_PopularProducts_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName" },
                values: new object[,]
                {
                    { 1, "Adana" },
                    { 6, "Ankara" },
                    { 61, "Trabzon" }
                });

            migrationBuilder.InsertData(
                table: "PopularProducts",
                columns: new[] { "ProductID", "CityID", "ProductName" },
                values: new object[,]
                {
                    { 1, 6, "Keçi" },
                    { 2, 1, "Şırdan" },
                    { 3, 1, "Aykut Bey" },
                    { 4, 61, "Tereyağ" },
                    { 5, 61, "Ekmek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PopularProducts_CityID",
                table: "PopularProducts",
                column: "CityID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PopularProducts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
