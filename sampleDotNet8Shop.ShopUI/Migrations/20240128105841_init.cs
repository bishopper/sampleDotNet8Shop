using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sampleDotNet8Shop.ShopUI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Mobile", "This is a IOS Phone And Create By Apple", "Apple IPhone 14 ProMax", 70000000 },
                    { 2, "Mobile", "This is a Android Phone And Create By Sumsung", "Sumsung Galexy S24 ultra", 45000000 },
                    { 3, "Mobile", "This is a Android Phone And Create By Xiaomi", "Xiaomi ME14 Ultra", 40000000 },
                    { 4, "Mobile", "This is a Android Phone And Create By Realme", "Realme C13 Ultra", 30000000 },
                    { 5, "Laptop", "The AMD-equipped Asus Zenbook 13 OLED is currently our top recommendation for a great budget laptop", "Asus Zenbook 13 OLED", 35000000 },
                    { 6, "Laptop", "The Dell XPS 15 is our current pick for best Windows laptop overall", " Dell XPS 15 OLED", 40000000 },
                    { 7, "Laptop", "The MacBook Air M2 is the best laptop for the money", "Macbook Air M2", 50000000 },
                    { 8, "PC", "The 24-inch iMac is especially well-suited as a family computer or if you want something other than a laptop to easily move from room to room", "Apple iMac M3(2024)", 20000000 },
                    { 9, "PC", "While we like all-in-ones for their convenience, they're not easy to upgrade (if they can be at all)", "Dell XPS 8960 Desktop", 16000000 },
                    { 10, "PC", "If you're dissatisfied with the lack of configuration options available for prebuilt gaming desktops", "Origin PC 5000T", 12000000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
