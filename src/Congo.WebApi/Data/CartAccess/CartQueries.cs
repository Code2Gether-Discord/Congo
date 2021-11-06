using System;
using System.Collections.Generic;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.CartAccess
{
    public record GetCartsQuery : IRequest<IEnumerable<Cart>>;

    public record GetCartItemsQuery(Guid Id) : IRequest<IEnumerable<CartItem>>;
}
