using System;

namespace Congo.WebApi.Data.Models;

public class Product
{

    public Guid Id { get; init; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string ImageUrl { get; set; }
}