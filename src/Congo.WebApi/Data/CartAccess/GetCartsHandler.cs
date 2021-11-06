using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data.CartAccess
{
    public class GetCartsHandler : IRequestHandler<GetCartsQuery, IEnumerable<Cart>>
    {
        private readonly CongoContext _dbContext;

        public GetCartsHandler(CongoContext dbContext) => _dbContext = dbContext;

        public Task<IEnumerable<Cart>> Handle(GetCartsQuery request, CancellationToken cancellationToken) =>
            Task.FromResult(_dbContext.Carts.AsNoTracking().AsEnumerable());
    }
}
