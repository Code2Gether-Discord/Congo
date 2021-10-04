using System;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.ProductAccess
{
    // TODO: This needs a Handler
    public record InsertProductCommand(string Name, string Description, decimal Price, string ImageUrl) : IRequest;
}
