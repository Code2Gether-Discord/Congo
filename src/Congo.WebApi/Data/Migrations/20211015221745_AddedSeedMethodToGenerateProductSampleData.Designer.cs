﻿// <auto-generated />
using System;
using Congo.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Congo.WebApi.Data.Migrations
{
    [DbContext(typeof(CongoContext))]
    [Migration("20211015221745_AddedSeedMethodToGenerateProductSampleData")]
    partial class AddedSeedMethodToGenerateProductSampleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Congo.WebApi.Data.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a047ba0b-58d7-45ac-8d49-647c9f92b2bf"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Screwdriver",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = new Guid("d1cd6557-984c-46f5-819a-79b6c5b5e210"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "AMD Ryzen 7 5900X",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = new Guid("67c458f5-f8c7-49b4-b874-6ad8da2a1e27"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "A Rock",
                            Price = 0.99m
                        },
                        new
                        {
                            Id = new Guid("0e162912-7a39-4df6-a4c0-d2a55f02e855"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "5-Piece Gardening Kit",
                            Price = 34.99m
                        },
                        new
                        {
                            Id = new Guid("d104a0b8-32b1-434e-a005-7ccbeba2af14"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Box of Chocolates",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = new Guid("db6a7d0b-630a-4125-8e70-d5f7c76c63be"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Window Cleaning Solution",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = new Guid("85149cb8-4aba-4ff0-92e4-81cea519c220"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Paper shredder",
                            Price = 44.99m
                        },
                        new
                        {
                            Id = new Guid("731bb48b-09dc-4291-88fc-85bcda4dea8f"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Xbox Controller",
                            Price = 119.99m
                        },
                        new
                        {
                            Id = new Guid("2ede58c0-b070-4b49-a8e9-5aaee4dc8124"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "LED Light Bulb - 8 pack",
                            Price = 44.99m
                        },
                        new
                        {
                            Id = new Guid("ee05fa67-e090-485e-aaee-e325bc2f60e4"),
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "A Dance With Dragons - Hard Cover",
                            Price = 39.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
