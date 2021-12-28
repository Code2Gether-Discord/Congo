namespace Congo.Contracts.Requests.Products;

public sealed class InsertProductRequest
{
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public string ImageUrl { get; set; }
}