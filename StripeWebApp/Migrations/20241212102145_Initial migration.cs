using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StripeWebApp.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceID = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "ImageUrl", "Name", "PriceID" },
                values: new object[,]
                {
                    { 1, "https://monochrome-watches.com/wp-content/uploads/2023/08/Jacob-and-Co-The-World-Is-Yours-Dual-Time-Zone-Watch-1.jpg", "Jacob & Co THE WORLD IS YOURS DUAL TIME ZONE", "price_1QV644FCRscjNLWmDLp9BYMl" },
                    { 2, "https://cdn.media.amplience.net/i/frasersdev/63708340_o.jpg?v=220121212030", "Jordan T-Shirt", "price_1QV5xOFCRscjNLWm2AAOVYjj" },
                    { 3, "https://mir-s3-cdn-cf.behance.net/project_modules/1400/5be63c100114067.5f024a0a667e0.jpg", "Summer T-Shirt", "price_1QV67AFCRscjNLWmGJIX1IHH" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
