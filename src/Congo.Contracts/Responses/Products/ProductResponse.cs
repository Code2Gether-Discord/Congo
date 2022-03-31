using System;

namespace Congo.Contracts.Responses.Products;

public sealed class ProductResponse
{
    public Guid Id { get; init; }

    public string Name { get; init; }

    public string Description { get; init; }

    public decimal Price { get; init; }

    public string ImageUrl { get; init; }
}