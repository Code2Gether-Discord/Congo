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
        private Cart _cart;

        public AddToCartHandler(CongoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(AddToCartCommand request, CancellationToken cancellationToken)
        {
            var cart = await _dbContext.Carts.FindAsync(request.cartId);
            var product = await _dbContext.Products.FindAsync(request.productId);
            if (request.cartId != null && cart != null)
            {
                _cart = cart;
            }
            else if (request.cartId == null)
            {
                _cart = new Cart()
                {
                    Id = Guid.NewGuid(),
                };
                await _dbContext.Carts.AddAsync(_cart);
            }
            else return Guid.Empty;

            var cartItem = await AddCartItem(request, request.quantity);
            await _dbContext.CartItems.AddAsync(cartItem);
            _dbContext.SaveChanges();

            return _cart.Id;
        }
        private async Task<CartItem> AddCartItem(AddToCartCommand request, int quantity)
        {
            return new CartItem
            {
                Id = Guid.NewGuid(),
                CartId = _cart.Id,
                Product = await _dbContext.Products.FirstOrDefaultAsync(p => p.Id == request.productId),
                Quantity = request.quantity
            };
        }
    }
    
}
