using System;

namespace Congo.WebApi.Data.Models
{
    public class CartItem
    {
        public Guid Id { get; init; }
        public Guid CartId { get; init; }
        public Guid ProductId { get; set; }
        public Product Product { get; init; }
        public int Quantity { get; set; }
    }
}
