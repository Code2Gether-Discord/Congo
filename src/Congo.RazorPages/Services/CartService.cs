
using System;
using System.Threading.Tasks;
using Congo.Contracts.Clients;
using Congo.Contracts.Responses.Cart;

namespace Congo.RazorPages.Services
{
    public class CartService : ICartService
    {
        private readonly ICongoUserClient _client;

        public CartService(ICongoUserClient client)
        {
            _client = client;
        }
        public async Task<CartResponse> GetCart(Guid cartId)
        {
            return (await _client.GetCart(cartId)).Content;

        }
    }
}
