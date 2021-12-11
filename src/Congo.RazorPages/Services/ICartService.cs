using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;

namespace Congo.RazorPages.Services
{
    public interface ICartService
    {
        Task<Guid> AddToCart(Guid cartId, Guid productId, int quantity);
        Task<CartResponse> GetCart(Guid cartId);
    }
}