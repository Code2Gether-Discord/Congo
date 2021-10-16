using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.RazorPages.Models;

namespace Congo.RazorPages.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<OrderConfirmationResponse> PurchaseAsync(Guid productId);
    }
}
