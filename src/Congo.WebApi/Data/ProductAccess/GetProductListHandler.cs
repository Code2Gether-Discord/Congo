using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data.ProductAccess
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, IEnumerable<Product>>
    {
        private readonly CongoContext _dbContext;

        public GetProductListHandler(CongoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dbContext.Products.AsNoTracking().AsEnumerable());
        }
    }
}
