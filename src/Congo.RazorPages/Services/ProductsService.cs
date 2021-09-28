using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
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
            return await client.GetFromJsonAsync<IEnumerable<Product>>(_productsUri);
        }
    }
}
