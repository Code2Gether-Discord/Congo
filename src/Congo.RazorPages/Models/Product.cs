using System;

namespace Congo.RazorPages.Models
{
    public class Product
    {
        //Draft to populate product page
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
