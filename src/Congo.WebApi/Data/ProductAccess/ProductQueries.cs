using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.ProductAccess;

public record GetProductListQuery : IRequest<IEnumerable<Product>>;