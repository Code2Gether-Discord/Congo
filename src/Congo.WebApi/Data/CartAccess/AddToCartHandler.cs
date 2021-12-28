using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using static Congo.WebApi.Data.CartAccess.CartCommands;

namespace Congo.WebApi.Data.CartAccess;

public class AddToCartHandler : IRequestHandler<AddToCartCommand, Guid>
{
    private readonly CongoContext _dbContext;

    public AddToCartHandler(CongoContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Guid> Handle(AddToCartCommand request, CancellationToken cancellationToken)
    {
        var cart = await _dbContext.Carts
            .Include(c => c.CartItems)
            .FirstOrDefaultAsync(C => C.Id == request.cartId);

        var product = await _dbContext.Products.FindAsync(request.productId);
            
        if (request.cartId != null && cart == null)
        {
            return Guid.Empty;
        }
        else if (request.cartId == null)
        {
            cart = new Cart()
            {
                Id = Guid.NewGuid(),
            };
            await _dbContext.Carts.AddAsync(cart);
        }

        await AddCartItem(request, cart, product, _dbContext);

        await _dbContext.SaveChangesAsync();

        return cart.Id;
    }

    private async Task AddCartItem(AddToCartCommand request, Cart cart, Product product, CongoContext _dbContext)
    {
        var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == request.productId);

        if (cartItem is not null)
        {
            cartItem.Quantity = request.quantity;
            return;
        }
        var item = new CartItem
        {
            Id = Guid.NewGuid(),
            CartId = cart.Id,
            Product = product,
            Quantity = request.quantity
        };
        cart.CartItems.Add(item);
        await _dbContext.AddAsync(item);
    }
}