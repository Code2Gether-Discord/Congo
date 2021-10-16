using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.RazorPages.Models;
using Congo.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.RazorPages.Pages
{
    public class ProductsModel : PageModel
    {
        public IEnumerable<Product> SampleData;
        private readonly IProductsService _productsService;

        [TempData] public string Message { get; set; }

        public ProductsModel(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            SampleData = await _productsService.GetProducts();

            return Page();
        }

        public async Task<IActionResult> OnPostPurchaseAsync(Guid id)
        {
            var order = await _productsService.PurchaseAsync(id);
            Message = $"Thanks for your purchase. Your order number is: {order.OrderId}";
            return RedirectToPage("/OrderSuccessful", new { order.OrderId });
        }
    }
}
