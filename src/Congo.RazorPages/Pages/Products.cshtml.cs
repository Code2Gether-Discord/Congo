using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.RazorPages.Pages
{
    public class ProductsModel : PageModel
    {
        public static List<Product> SampleData;
        
        public void OnGet()
        {
            SampleData = new List<Product>()
            {
                new()
                {
                    Id = 1,
                    Title = "Screwdriver",
                    Price = 5.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 2,
                    Title = "AMD Ryzen 7 5900X",
                    Price = 499.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 3,
                    Title = "A Rock",
                    Price = 0.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 4,
                    Title = "5-Piece Gardening Kit",
                    Price = 34.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                }, 
                new()
                {
                    Id = 5,
                    Title = "Box of Chocolates",
                    Price = 9.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 6,
                    Title = "Window Cleaning Solution",
                    Price = 4.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 7,
                    Title = "Paper shredder",
                    Price = 44.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 8,
                    Title = "Xbox Controller",
                    Price = 119.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 9,
                    Title = "LED Light Bulb - 8 pack",
                    Price = 44.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = 10,
                    Title = "A Dance With Dragons - Hard Cover",
                    Price = 39.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
            };
        }
    }
}