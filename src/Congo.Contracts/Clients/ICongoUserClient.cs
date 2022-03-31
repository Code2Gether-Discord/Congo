using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.Contracts.Responses.Products;
using Refit;

namespace Congo.Contracts.Clients;

public interface ICongoUserClient
{
    [Get("/api/products")]
    Task<ApiResponse<IEnumerable<ProductResponse>>> GetProducts();

    [Post("/api/products/{id}/purchase")]
    Task<ApiResponse<OrderConfirmationResponse>> PurchaseProduct(Guid id);
}
