using System;
using Congo.Contracts.Responses.Products;

namespace Congo.Contracts.Responses.Cart
{
    public sealed class CartItemResponse
    {
        public Guid Id { get; init; }

        public int Amount { get; set; }

        public decimal TotalPrice { get; set; }

        public ProductResponse Product { get; init; }
    }
}
