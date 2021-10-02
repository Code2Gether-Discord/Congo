using Congo.WebApi.Data.Models;
using MediatR;
using System.Collections.Generic;

namespace Congo.WebApi.Data.ProductAccess
{
    public record GetProductListQuery() : IRequest<List<Product>>;
}