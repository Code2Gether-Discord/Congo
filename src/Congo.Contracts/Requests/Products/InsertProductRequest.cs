namespace Congo.Contracts.Requests.Products
{
    public sealed class InsertProductRequest
    {
        public string Name { get; init; }

        public string Description { get; init; }

        public decimal Price { get; init; }

        public string ImageUrl { get; init; }
    }
}
