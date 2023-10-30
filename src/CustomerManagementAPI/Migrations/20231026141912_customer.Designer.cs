﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pitstop.CustomerManagementAPI.DataAccess;

#nullable disable

namespace Pitstop.CustomerManagementAPI.DataAccess
{
    [DbContext(typeof(CustomerManagementDBContext))]
    [Migration("20231026141912_customer")]
    partial class customer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pitstop.CustomerManagementAPI.Model.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelephoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);

                    b.HasData(
                        new
                        {
                            CustomerId = "1",
                            Address = "123 Main Street",
                            City = "Sample City",
                            EmailAddress = "john.doe@example.com",
                            Name = "John Doe",
                            PostalCode = "12345",
                            TelephoneNumber = "123-456-7890"
                        },
                        new
                        {
                            CustomerId = "2",
                            Address = "456 Elm Street",
                            City = "Another City",
                            EmailAddress = "jane.smith@example.com",
                            Name = "Jane Smith",
                            PostalCode = "67890",
                            TelephoneNumber = "987-654-3210"
                        },
                        new
                        {
                            CustomerId = "3",
                            Address = "789 Oak Street",
                            City = "Yet Another City",
                            EmailAddress = "bob.johnson@example.com",
                            Name = "Bob Johnson",
                            PostalCode = "54321",
                            TelephoneNumber = "111-222-3333"
                        },
                        new
                        {
                            CustomerId = "4",
                            Address = "101 Pine Street",
                            City = "Final City",
                            EmailAddress = "alice.brown@example.com",
                            Name = "Alice Brown",
                            PostalCode = "13579",
                            TelephoneNumber = "999-888-7777"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
