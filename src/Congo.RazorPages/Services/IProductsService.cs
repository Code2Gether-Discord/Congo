using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.Contracts.Responses.Products;

namespace Congo.RazorPages.Services;

public interface IProductsService
{
    Task<IEnumerable<ProductResponse>> GetProducts();
    Task<OrderConfirmationResponse> PurchaseAsync(Guid productId);
}