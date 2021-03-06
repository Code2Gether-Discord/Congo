using System;
using MediatR;

namespace Congo.WebApi.Data.CartAccess
{
    public class CartCommands
    {
        public record AddToCartCommand(Guid? cartId, Guid productId, int quantity) : IRequest<Guid>;
    }
}
