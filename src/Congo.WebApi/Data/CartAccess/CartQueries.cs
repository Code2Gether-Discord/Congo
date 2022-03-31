using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.CartAccess;

public record GetCartQuery(Guid Id) : IRequest<Cart>;