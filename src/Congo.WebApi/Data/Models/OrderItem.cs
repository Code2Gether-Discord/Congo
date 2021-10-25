using System;

namespace Congo.WebApi.Data.Models
{
    public class OrderItem
    {
        public int Amount { get; set; }
        public Guid Id { get; init; }
        public Guid ProductId { get; init; }
        public decimal Price { get; set; }
    }
}
