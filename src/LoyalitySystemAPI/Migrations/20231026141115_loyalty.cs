using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LoyalitySystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class loyalty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Loyalty",
                columns: new[] { "CustomerID", "Category", "Points" },
                values: new object[,]
                {
                    { "1", "zilver", "100" },
                    { "2", "zilver", "200" },
                    { "3", "platina", "2000" },
                    { "4", "goud", "600" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Loyalty",
                keyColumn: "CustomerID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Loyalty",
                keyColumn: "CustomerID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Loyalty",
                keyColumn: "CustomerID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Loyalty",
                keyColumn: "CustomerID",
                keyValue: "4");
        }
    }
}
