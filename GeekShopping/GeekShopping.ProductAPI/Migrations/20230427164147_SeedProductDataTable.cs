using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "T-shirt", "Description", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/27ab0becda80bca82da59de96356da15f8bc0c80/ShoppingImages/8_moletom_cobra_kay.jpg", "Moletom Cobra Kay", 69.9m },
                    { 3L, "T-shirt", "Description", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/27ab0becda80bca82da59de96356da15f8bc0c80/ShoppingImages/7_coffee.jpg", "Camiseta BENEFITS OF DRINKS COFFEE", 30.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);
        }
    }
}
