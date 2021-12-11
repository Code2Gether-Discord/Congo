using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;
using Congo.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.RazorPages.Pages
{
    public class CartModel : PageModel
    {
        public CartResponse Cart { get; set; }
        private readonly ICartService _cartService;

        public CartModel(ICartService cartService) => _cartService = cartService;

        public async Task<IActionResult> OnGetAsync(Guid cartId)
        {
            Cart = await _cartService.GetCart(cartId);
            return Page();
        }


    }
}
