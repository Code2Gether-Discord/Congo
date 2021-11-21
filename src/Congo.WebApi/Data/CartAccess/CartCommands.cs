using System;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.CartAccess
{
    public class CartCommands
    {
        public record AddToCartCommand(Guid? cartId, Product product) : IRequest<Guid>;
    }
}
