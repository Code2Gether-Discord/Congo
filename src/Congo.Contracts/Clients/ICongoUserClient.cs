using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;
using Congo.Contracts.Responses.Orders;
using Congo.Contracts.Responses.Products;
using Refit;

namespace Congo.Contracts.Clients
{
    public interface ICongoUserClient
    {
        [Get("/api/products")]
        Task<ApiResponse<IEnumerable<ProductResponse>>> GetProducts();

        [Post("/api/products/{id}/purchase")]
        Task<ApiResponse<OrderConfirmationResponse>> PurchaseProduct(Guid id);

        [Get("/api/Cart/{id}")]
        Task<ApiResponse<CartResponse>> GetCart(Guid id);

        [Post("/add-to-cart")]
        Task<ApiResponse<Guid>> AddToCart(Guid cartId, Guid productId, int quantity = 1);
    }
}
