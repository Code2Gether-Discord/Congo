using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Congo.RazorPages.Pages
{
    public class OrderSuccessful : PageModel
    {
        [FromQuery(Name = "orderId")] public Guid OrderId { get; set; }

        public void OnGet()
        {
        }
    }
}
