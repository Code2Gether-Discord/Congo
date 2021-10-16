using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public static Product[] SeedProducts()
        {
            return new Product[]
            {
                 new Product
                     {
                         Id = Guid.NewGuid(),
                         Name = "Screwdriver",
                         Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                         Price = 5.99m,
                         ImageUrl = "https://via.placeholder.com/150"
                     },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "AMD Ryzen 7 5900X",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 499.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "A Rock",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 0.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "5-Piece Gardening Kit",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 34.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Box of Chocolates",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 9.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Window Cleaning Solution",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 4.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Paper shredder",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 44.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Xbox Controller",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 119.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "LED Light Bulb - 8 pack",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 44.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "A Dance With Dragons - Hard Cover",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla vestibulum lacus augue, a tempor enim sollicitudin eu. Pellentesque odio nulla, maximus id mattis posuere, semper ac massa. Donec quis lectus eros. Sed ac fringilla nunc. Proin lacus nisi, fermentum quis interdum nec, blandit in sapien. Phasellus bibendum volutpat tortor, a sagittis sapien finibus id. Etiam urna est, sagittis eget orci et, finibus luctus lacus. ",
                        Price = 39.99m,
                        ImageUrl = "https://via.placeholder.com/150"
                    }
            };
        }
    }
}
