using System;
using System.Collections.Generic;
using System.Linq;

namespace Congo.WebApi.Data.Models
{
    public class Order
    {
        public Guid Id { get; init; }
        public ICollection<OrderItem> OrderItems { get; } = new List<OrderItem>();
        public decimal TotalPrice => OrderItems.Sum(x => x.Price * x.Amount);
    }
}
