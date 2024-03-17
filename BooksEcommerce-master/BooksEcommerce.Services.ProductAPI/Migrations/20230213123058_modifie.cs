using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksEcommerce.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class modifie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(55)", maxLength: 55, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Authorid = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Author1" },
                    { 2, "Author2" },
                    { 3, "Author3" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Authorid", "Description", "ISBN", "ImageURL", "InStock", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Description1", "3", "https://artisanmc.blob.core.windows.net/artisana/1.jpg", 10, 200.0, "Title1" },
                    { 2, 1, "Description2", "5", "https://artisanmc.blob.core.windows.net/artisana/2.jpg", 20, 210.0, "Title2" },
                    { 3, 1, "Description3", "4", "https://artisanmc.blob.core.windows.net/artisana/3.jpg", 30, 220.0, "Title3" },
                    { 4, 2, "Description4", "1", "https://artisanmc.blob.core.windows.net/artisana/4.jpg", 30, 230.0, "Title4" },
                    { 5, 2, "Description5", "2", "https://artisanmc.blob.core.windows.net/artisana/5.jpg", 10, 220.0, "Title5" },
                    { 6, 2, "Description6", "3", "https://artisanmc.blob.core.windows.net/artisana/6.jpg", 10, 220.0, "Title6" },
                    { 7, 3, "Description7", "2", "https://artisanmc.blob.core.windows.net/artisana/7.jpg", 10, 200.0, "Title7" },
                    { 8, 3, "Description8", "3", "https://artisanmc.blob.core.windows.net/artisana/8.jpg", 10, 280.0, "Title8" },
                    { 9, 3, "Description5", "3", "https://artisanmc.blob.core.windows.net/artisana/9.jpg", 10, 290.0, "Title9" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Categories1" },
                    { 2, "Categories2" },
                    { 3, "Categories3" },
                    { 4, "Categories4" },
                    { 5, "Categories5" },
                    { 6, "Categories6" },
                    { 7, "Categories7" },
                    { 8, "Categories8" },
                    { 9, "Categories9" },
                    { 10, "Categories10" },
                    { 11, "Categories11" },
                    { 12, "Categories12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
