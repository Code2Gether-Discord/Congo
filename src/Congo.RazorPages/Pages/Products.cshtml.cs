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

        public async Task<IActionResult> OnGet()
        {
            SampleData = await _productsService.GetProducts();

            return Page();
        }

        public ActionResult OnPostPurchase(int id)
        {
            _productsService.PurchaseProduct(id);
            Message = $"Thanks for buying product with id: {id}";
            return RedirectToPage(); // refresh the page
        }
    }
}
