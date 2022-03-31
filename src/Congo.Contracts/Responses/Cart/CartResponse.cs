using System;
using System.Collections.Generic;

namespace Congo.Contracts.Responses.Cart;

public sealed class CartResponse
{
    public Guid Id { get; init; }

    public IReadOnlyCollection<CartItemResponse> CartItems { get; init; }

    public decimal TotalPrice { get; init; }

    public int Count { get; init; }
}