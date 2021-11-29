using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;

namespace Congo.RazorPages.Services
{
    public interface ICartService
    {

        Task<CartResponse> GetCart(Guid? cartId = null);
    }
}
