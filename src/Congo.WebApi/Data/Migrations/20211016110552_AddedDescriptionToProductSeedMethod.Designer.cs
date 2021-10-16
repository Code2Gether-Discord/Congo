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
    [Migration("20211016110552_AddedDescriptionToProductSeedMethod")]
    partial class AddedDescriptionToProductSeedMethod
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
                            Id = new Guid("4e434a20-7661-458e-9be0-994b01272f85"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Screwdriver",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = new Guid("511fa7ab-f70b-45a1-827b-d9214fc80fd3"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "AMD Ryzen 7 5900X",
                            Price = 499.99m
                        },
                        new
                        {
                            Id = new Guid("66ec0969-5566-4752-83e6-828e047a2c0e"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "A Rock",
                            Price = 0.99m
                        },
                        new
                        {
                            Id = new Guid("7f2090cc-c768-4ee8-8595-65a8d6555678"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "5-Piece Gardening Kit",
                            Price = 34.99m
                        },
                        new
                        {
                            Id = new Guid("9ca58986-b5f5-4106-bf76-cf084f8ffb7f"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Box of Chocolates",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = new Guid("a50eb43e-5047-4722-a5f7-e5012c3c3121"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Window Cleaning Solution",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = new Guid("5119d346-7730-478b-a45b-98e4e01126b7"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Paper shredder",
                            Price = 44.99m
                        },
                        new
                        {
                            Id = new Guid("8a421ed9-5374-4a6c-a0b9-f3682e1a3ac1"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "Xbox Controller",
                            Price = 119.99m
                        },
                        new
                        {
                            Id = new Guid("bf8dd84e-7d15-4d3b-a012-542531124288"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "LED Light Bulb - 8 pack",
                            Price = 44.99m
                        },
                        new
                        {
                            Id = new Guid("4de38e9f-70dc-497a-b791-e7c41ddd6158"),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                            ImageUrl = "https://via.placeholder.com/150",
                            Name = "A Dance With Dragons - Hard Cover",
                            Price = 39.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
