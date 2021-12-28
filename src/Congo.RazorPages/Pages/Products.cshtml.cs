using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Products;
using Congo.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.RazorPages.Pages;

public class ProductsModel : PageModel
{
    public IEnumerable<ProductResponse> Products;
    private readonly IProductsService _productsService;


    public ProductsModel(IProductsService productsService)
    {
        _productsService = productsService;
    }

    public async Task<IActionResult> OnGetAsync()
    {
        Products = await _productsService.GetProducts();

        return Page();
    }

    public async Task<IActionResult> OnPostPurchaseAsync(Guid id)
    {
        var order = await _productsService.PurchaseAsync(id);
        return RedirectToPage("/OrderSuccessful", new { order.OrderId });
    }
}