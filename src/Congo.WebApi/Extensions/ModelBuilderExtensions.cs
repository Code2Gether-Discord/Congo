using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Congo.WebApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(JsonSerializer.Deserialize<IEnumerable<Product>>(File.ReadAllText("Data/products.json")));
        }
    }
}
