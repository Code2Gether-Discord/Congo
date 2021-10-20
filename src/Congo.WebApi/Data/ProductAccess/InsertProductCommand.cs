using System;
using MediatR;

namespace Congo.WebApi.Data.ProductAccess
{
    public record InsertProductCommand(string Name, string Description, decimal Price, string ImageUrl) : IRequest<Guid>;
}
