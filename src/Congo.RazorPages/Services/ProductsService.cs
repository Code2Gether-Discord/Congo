using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Clients;
using Congo.Contracts.Responses.Orders;
using Congo.Contracts.Responses.Products;

namespace Congo.RazorPages.Services;

public class ProductsService : IProductsService
{
    private readonly ICongoUserClient _client;

    public ProductsService(ICongoUserClient client)
    {
        _client = client;
    }

    public async Task<IEnumerable<ProductResponse>> GetProducts()
    {
        return (await _client.GetProducts()).Content;
    }

    public async Task<OrderConfirmationResponse> PurchaseAsync(Guid productId)
    {
        return (await _client.PurchaseProduct(productId)).Content;
    }
}