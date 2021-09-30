using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.RazorPages.Models;
using Congo.RazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;

namespace Congo.RazorPages.Pages
{
    public class ProductsModel : PageModel
    {
        public static List<Product> SampleData;
        
        public void OnGet([FromServices] IProductsService productsService)
        {
            SampleData = productsService.GetSampleProducts();
        }
    }
}