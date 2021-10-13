using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.RazorPages.Models;

namespace Congo.RazorPages.Services
{
    public class ProductsService : IProductsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _productsUri = $"{nameof(Product)}s";

        public ProductsService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient(nameof(Congo));
            return await client.GetFromJsonAsync<IEnumerable<Product>>($"/api/{_productsUri}");
        }

        public IEnumerable<Product> GetSampleProducts()
        {
            return new List<Product>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Screwdriver",
                    Price = 5.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "AMD Ryzen 7 5900X",
                    Price = 499.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "A Rock",
                    Price = 0.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "5-Piece Gardening Kit",
                    Price = 34.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Box of Chocolates",
                    Price = 9.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Window Cleaning Solution",
                    Price = 4.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Paper shredder",
                    Price = 44.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "Xbox Controller",
                    Price = 119.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "LED Light Bulb - 8 pack",
                    Price = 44.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Title = "A Dance With Dragons - Hard Cover",
                    Price = 39.99m,
                    ImageUrl = "https://via.placeholder.com/150"
                },
            };
        }

        public async Task<Guid> Purchase(Guid productId)
        {
            /* Uses the HttpClientFactory directly for now, will change it to use
            Refit when it gets implemented. */
            var client = _httpClientFactory.CreateClient(nameof(Congo));
            var response = await client.PostAsync($"/api/{_productsUri}/{productId}/purchase", null);
            var result = await response.Content.ReadFromJsonAsync<OrderConfirmationResponse>();
            return result.OrderId;
        }
    }
}
