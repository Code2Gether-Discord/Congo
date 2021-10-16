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
        private readonly string _productsUri = $"Products";

        public ProductsService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient(nameof(Congo));
            return await client.GetFromJsonAsync<IEnumerable<Product>>($"{_productsUri}");
        }

        public async Task<OrderConfirmationResponse> PurchaseAsync(Guid productId)
        {
            /* Uses the HttpClientFactory directly for now, will change it to use
            Refit when it gets implemented. */
            var client = _httpClientFactory.CreateClient(nameof(Congo));
            var response = await client.PostAsync($"{_productsUri}/{productId}/purchase", null);
            var result = await response.Content.ReadFromJsonAsync<OrderConfirmationResponse>();
            return result;
        }
    }
}
