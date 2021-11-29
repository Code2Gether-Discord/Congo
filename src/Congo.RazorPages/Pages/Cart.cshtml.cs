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
        public CartResponse Cart;
        private readonly ICartService _cartService;

        public CartModel(ICartService cartService)
        {
            _cartService = cartService;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            string cartId;
            if (Request.Cookies.ContainsKey("cartId"))
                Cart = await _cartService.GetCart(Guid.Parse(Request.Cookies["cartId"]));
            else
            {
                cartId = (await _cartService.GetCart()).ToString();
                Response.Cookies.Append("cartId", cartId);
            }

            return Page();
        }
    }
}
