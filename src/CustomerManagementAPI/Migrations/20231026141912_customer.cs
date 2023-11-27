using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pitstop.CustomerManagementAPI.DataAccess
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "City", "EmailAddress", "Name", "PostalCode", "TelephoneNumber" },
                values: new object[,]
                {
                    { "1", "123 Main Street", "Sample City", "john.doe@example.com", "John Doe", "12345", "123-456-7890" },
                    { "2", "456 Elm Street", "Another City", "jane.smith@example.com", "Jane Smith", "67890", "987-654-3210" },
                    { "3", "789 Oak Street", "Yet Another City", "bob.johnson@example.com", "Bob Johnson", "54321", "111-222-3333" },
                    { "4", "101 Pine Street", "Final City", "alice.brown@example.com", "Alice Brown", "13579", "999-888-7777" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: "4");
        }
    }
}
