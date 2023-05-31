using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TigerS.H.O.P.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Clothes for the little ones");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Description", "Price", "ProductImage", "Size", "Title" },
                values: new object[,]
                {
                    { 5, "Blue, White, Green, Red, Yellow", "Fantastic t-shirt for everyone", 399m, "/lib/images/tiger5.jpg", "XS-XXL", "T-Shirt" },
                    { 6, "Tiger", "Costume för children", 799m, "/lib/images/tiger6.jpg", "3-8 year", "Children's costume" },
                    { 7, "Tiger", "Nice, super nice", 2999m, "/lib/images/tiger7.jpg", "XS-XXXL", "Suit jacket" },
                    { 8, "Tiger", "Dress for everyday use", 1499m, "/lib/images/tiger8.jpg", "XS-XXXL", "Tiger Style" },
                    { 9, "Tiger", "Dress for everyday use", 7999m, "/lib/images/tiger9.jpg", "XS-XXXL", "Dress" },
                    { 10, "Red, Blue", "Lovely shirt", 299m, "/lib/images/tiger10.jpg", "XS-XXXL", "Shirt" },
                    { 11, "Tiger", "Super cool long sleeved tiger motive", 349m, "/lib/images/tiger11.jpg", "XS-XXXL", "Long sleeved" },
                    { 12, "Black, White", "Dress for special partys", 999m, "/lib/images/tiger12.jpg", "XS-XXXL", "Dress" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Hoodie for everyone");
        }
    }
}
