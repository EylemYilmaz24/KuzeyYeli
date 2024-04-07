﻿// <auto-generated />
using System;
using KuzeyYeli.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KuzeyYeli.Migrations
{
    [DbContext(typeof(KuzeyYeliContext))]
    [Migration("20240407011056_m1")]
    partial class m1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipperId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ShipperId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UnitsInStock")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.ProductSupplier", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "SupplierId");

                    b.HasIndex("SupplierId");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Shipper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("ShipTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipperDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipperName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Shipper", (string)null);
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Supplier", (string)null);
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Order", b =>
                {
                    b.HasOne("KuzeyYeli.Models.Entities.Customer", "Customer")
                        .WithMany("OrderList")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KuzeyYeli.Models.Entities.Shipper", "Shipper")
                        .WithMany("OrderList")
                        .HasForeignKey("ShipperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Shipper");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Product", b =>
                {
                    b.HasOne("KuzeyYeli.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KuzeyYeli.Models.Entities.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.ProductSupplier", b =>
                {
                    b.HasOne("KuzeyYeli.Models.Entities.Product", "Product")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KuzeyYeli.Models.Entities.Supplier", "Supplier")
                        .WithMany("ProductSuppliers")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Customer", b =>
                {
                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Product", b =>
                {
                    b.Navigation("ProductSuppliers");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Shipper", b =>
                {
                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("KuzeyYeli.Models.Entities.Supplier", b =>
                {
                    b.Navigation("ProductSuppliers");
                });
#pragma warning restore 612, 618
        }
    }
}
