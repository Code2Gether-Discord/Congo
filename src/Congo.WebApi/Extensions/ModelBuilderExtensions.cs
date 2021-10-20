using System;
using System.Collections.Generic;
using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    SeedProducts()
                );
        }

        public static IEnumerable<Product> SeedProducts()
        {
            var productNames = new string[]
            {
                "Screwdriver",
                "AMD Ryzen 7 5900X",
                "A Rock",
                "5-Piece Gardening Kit",
                "Box of Chocolates",
                "Window Cleaning Solution",
                "Paper shredder",
                "Xbox Controller",
                "LED Light Bulb - 8 pack",
                "A Dance With Dragons - Hard Cover",
                "Licensed Steel Pants",
                "Practical Steel Gloves",
                "Refined Plastic Shoes",
                "Incredible Fresh Fish",
                "Practical Granite Cheese",
                "Sleek Soft Chair",
                "Generic Steel Chair",
                "Refined Concrete Shoes",
                "Tasty Rubber Table",
                "Handmade Steel Ball",
                "Jewelery",
                "Refined Cotton Gloves",
                "Generic Rubber Pants",
                "Fantastic Plastic Table",
            };

            var random = new Random();
            for (int i = 0; i < 2; i++)
            {
                foreach (var productName in productNames)
                {
                    yield return new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = $"{productName} - {i + 1}",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a " +
                        "tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis " +
                        "lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus " +
                        "bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = (decimal)NextDouble(random, 0.99, 999.99),
                        ImageUrl = "https://via.placeholder.com/150",
                    };
                }
            }
        }
        private static double NextDouble(Random random, double min, double max) => random.NextDouble() * (max - min) + min;
    }
}
