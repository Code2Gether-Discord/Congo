using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data.CartAccess
{
    public class GetCartHandler : IRequestHandler<GetCartQuery, Cart>
    {
        private readonly CongoContext _dbContext;

        public GetCartHandler(CongoContext dbContext) => _dbContext = dbContext;

        public async Task<Cart> Handle(GetCartQuery request, CancellationToken cancellationToken)
        {
            var cart = await _dbContext.Carts
                .AsNoTracking()
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Product)
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            _ = cart ?? throw new KeyNotFoundException($"Cart with id: {request.Id} was not found");
            return cart;
        }
    }
}
