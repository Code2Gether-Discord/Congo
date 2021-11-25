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
            var cart = await _dbContext.Carts.FirstOrDefaultAsync(C => C.Id == request.cartId);
            var product = await _dbContext.Products.FindAsync(request.productId);
            
            if (request.cartId != null && cart != null)
            {
                _cart = cart;
            }
            else if (request.cartId == null)
            {
                cart = new Cart()
                {
                    Id = Guid.NewGuid(),
                };
            }
            else return Guid.Empty;
            // This sets the cart.

            var cartItem = await AddCartItem(request, cart, product);
            
            if (!await _dbContext.CartItems.ContainsAsync(cartItem))
            {
                cart.CartItems.Add(cartItem);
                await _dbContext.CartItems.AddAsync(cartItem);
            }
            if (!await _dbContext.Carts.ContainsAsync(cart))
            {
                await _dbContext.Carts.AddAsync(cart);
            }
            
            _dbContext.SaveChanges();

            return cart.Id;
        }
        private async Task<CartItem> AddCartItem(AddToCartCommand request, Cart cart, Product product)
        {
            foreach (CartItem item in cart.CartItems)
            {
                if (item.Product.Id == request.productId)
                {
                    item.Quantity = request.quantity;
                    return item;
                }
            }
            return new CartItem
            {
                Id = Guid.NewGuid(),
                CartId = cart.Id,
                Product = product,
                Quantity = request.quantity
            };
        }
    }    
}
