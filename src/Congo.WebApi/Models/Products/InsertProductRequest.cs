using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.WebApi.Models.Products
{
    public class InsertProductRequest
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0, (double)Decimal.MaxValue)]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
