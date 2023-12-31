﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pitstop.VehicleManagement.DataAccess;

#nullable disable

namespace Pitstop.VehicleManagementAPI.DataAccess
{
    [DbContext(typeof(VehicleManagementDBContext))]
    [Migration("20231026142737_vehicle")]
    partial class vehicle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pitstop.VehicleManagement.Model.Vehicle", b =>
                {
                    b.Property<string>("LicenseNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LicenseNumber");

                    b.ToTable("Vehicle", (string)null);

                    b.HasData(
                        new
                        {
                            LicenseNumber = "123ABC",
                            Brand = "Toyota",
                            OwnerId = "1",
                            Type = "Sedan"
                        },
                        new
                        {
                            LicenseNumber = "456DEF",
                            Brand = "Honda",
                            OwnerId = "2",
                            Type = "SUV"
                        },
                        new
                        {
                            LicenseNumber = "789GHI",
                            Brand = "Ford",
                            OwnerId = "3",
                            Type = "Truck"
                        },
                        new
                        {
                            LicenseNumber = "101JKL",
                            Brand = "Chevrolet",
                            OwnerId = "4",
                            Type = "Convertible"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
