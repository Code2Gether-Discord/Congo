using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data.CartAccess
{
    public class GetCartItemsHandler : IRequestHandler<GetCartItemsQuery, IEnumerable<CartItem>>
    {
        private readonly CongoContext _dbContext;

        public GetCartItemsHandler(CongoContext dbContext) => _dbContext = dbContext;

        public async Task<IEnumerable<CartItem>> Handle(GetCartItemsQuery request, CancellationToken cancellationToken)
        {
            var cart = await _dbContext.Carts.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            _ = cart ?? throw new KeyNotFoundException($"Cart with id: {request.Id} was not found");
            return cart.CartItems;
        }
    }
}
