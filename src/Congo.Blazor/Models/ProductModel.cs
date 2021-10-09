using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Congo.Blazor.Models
{
    public class ProductModel
    {
        public string Name { get; init; }

        public string Description { get; init; }

        public decimal Price { get; init; }

        public string ImageUrl { get; init; }
    }
}
