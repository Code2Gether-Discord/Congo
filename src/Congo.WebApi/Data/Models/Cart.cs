using System;
using System.Collections.Generic;

namespace Congo.WebApi.Data.Models;

public class Cart
{
    public Guid Id { get; init; }
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
}