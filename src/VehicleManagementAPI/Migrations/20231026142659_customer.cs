using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pitstop.VehicleManagementAPI.DataAccess
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicle",
                columns: new[] { "LicenseNumber", "Brand", "OwnerId", "Type" },
                values: new object[,]
                {
                    { "101JKL", "Chevrolet", "4", "Convertible" },
                    { "123ABC", "Toyota", "1", "Sedan" },
                    { "456DEF", "Honda", "2", "SUV" },
                    { "789GHI", "Ford", "3", "Truck" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "LicenseNumber",
                keyValue: "101JKL");

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "LicenseNumber",
                keyValue: "123ABC");

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "LicenseNumber",
                keyValue: "456DEF");

            migrationBuilder.DeleteData(
                table: "Vehicle",
                keyColumn: "LicenseNumber",
                keyValue: "789GHI");
        }
    }
}
