﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TigerS.H.O.P.Data;

#nullable disable

namespace TigerS.H.O.P.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230529082625_third")]
    partial class third
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TigerS.H.O.P.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("TigerS.H.O.P.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TigerS.H.O.P.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TigerS.H.O.P.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Blue, White, Green, Red",
                            Description = "Cool T-Shirt",
                            Price = 99m,
                            ProductImage = "/lib/images/tiger1.jpg",
                            Size = "XS-XXL",
                            Title = "T-Shirt"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Blue, White, Green, Red",
                            Description = "Hoodie for everyone",
                            Price = 299m,
                            ProductImage = "/lib/images/tiger2.jpg",
                            Size = "XS-XXL",
                            Title = "Hoodie"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Blue, White, Green, Red",
                            Description = "Clothes for the little ones",
                            Price = 179m,
                            ProductImage = "/lib/images/tiger3.jpg",
                            Size = "3-9 Year",
                            Title = "Child"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Blue, White, Green, Red",
                            Description = "Hoodie for everyone",
                            Price = 799m,
                            ProductImage = "/lib/images/tiger4.jpg",
                            Size = "XS-XXL",
                            Title = "Deluxe"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Blue, White, Green, Red, Yellow",
                            Description = "Fantastic t-shirt for everyone",
                            Price = 399m,
                            ProductImage = "/lib/images/tiger5.jpg",
                            Size = "XS-XXL",
                            Title = "T-Shirt"
                        },
                        new
                        {
                            Id = 6,
                            Color = "Tiger",
                            Description = "Costume för children",
                            Price = 799m,
                            ProductImage = "/lib/images/tiger6.jpg",
                            Size = "3-8 year",
                            Title = "Children's costume"
                        },
                        new
                        {
                            Id = 7,
                            Color = "Tiger",
                            Description = "Nice, super nice",
                            Price = 2999m,
                            ProductImage = "/lib/images/tiger7.jpg",
                            Size = "XS-XXXL",
                            Title = "Suit jacket"
                        },
                        new
                        {
                            Id = 8,
                            Color = "Tiger",
                            Description = "Dress for everyday use",
                            Price = 1499m,
                            ProductImage = "/lib/images/tiger8.jpg",
                            Size = "XS-XXXL",
                            Title = "Tiger Style"
                        },
                        new
                        {
                            Id = 9,
                            Color = "Tiger",
                            Description = "Dress for everyday use",
                            Price = 7999m,
                            ProductImage = "/lib/images/tiger9.jpg",
                            Size = "XS-XXXL",
                            Title = "Dress"
                        },
                        new
                        {
                            Id = 10,
                            Color = "Red, Blue",
                            Description = "Lovely shirt",
                            Price = 299m,
                            ProductImage = "/lib/images/tiger10.jpg",
                            Size = "XS-XXXL",
                            Title = "Shirt"
                        },
                        new
                        {
                            Id = 11,
                            Color = "Tiger",
                            Description = "Super cool long sleeved tiger motive",
                            Price = 349m,
                            ProductImage = "/lib/images/tiger11.jpg",
                            Size = "XS-XXXL",
                            Title = "Long sleeved"
                        },
                        new
                        {
                            Id = 12,
                            Color = "Black, White",
                            Description = "Dress for special partys",
                            Price = 999m,
                            ProductImage = "/lib/images/tiger12.jpg",
                            Size = "XS-XXXL",
                            Title = "Dress"
                        });
                });

            modelBuilder.Entity("TigerS.H.O.P.Models.CartItem", b =>
                {
                    b.HasOne("TigerS.H.O.P.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TigerS.H.O.P.Models.OrderItem", b =>
                {
                    b.HasOne("TigerS.H.O.P.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TigerS.H.O.P.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TigerS.H.O.P.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
