using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Congo.WebApi.Data.CartAccess.CartCommands;

namespace Congo.WebApi.Data.CartAccess
{
    public class AddToCartHandler : IRequestHandler<AddToCartCommand, Guid>
    {
        private readonly CongoContext _dbContext;
        private Cart cart;

        public AddToCartHandler(CongoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            
            if (request.cartId != null)
            {
                cart = await _dbContext.Carts.FirstOrDefaultAsync(c => c.Id == request.cartId);
            }
            else
            {
                cart = new Cart();
            }
                
            var cartItem = new CartItem
            {
                Id = request.product.Id,
                CartId = cart.Id,
                Product = request.product,
                Quantity = 1

            };
            await _dbContext.CartItems.AddAsync(cartItem);

            await _dbContext.SaveChangesAsync();

            return cart.Id;
        }

    }    
}
