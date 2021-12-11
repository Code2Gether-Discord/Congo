using System;
using System.Threading.Tasks;
using Congo.Contracts.Clients;
using Congo.Contracts.Responses.Cart;

namespace Congo.RazorPages.Services
{
    public class CartService : ICartService
    {
        private readonly ICongoUserClient _client;

        public CartService(ICongoUserClient client) => _client = client;

        public async Task<CartResponse> GetCart(Guid cartId)
        {
            var result = (await _client.GetCart(cartId));
            return result.Content;
        }

        public async Task<Guid> AddToCart(Guid cartId, Guid productId, int quantity)
        {
            return (await _client.AddToCart(cartId, productId, quantity)).Content;
        }
    }
}
