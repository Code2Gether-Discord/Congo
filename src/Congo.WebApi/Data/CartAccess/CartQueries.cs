using System;
using System.Collections.Generic;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.CartAccess
{
    public record GetCartsQuery : IRequest<IEnumerable<Cart>>;

    public record GetCartQuery(Guid Id) : IRequest<Cart>;
}
