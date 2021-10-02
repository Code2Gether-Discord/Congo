using Congo.WebApi.Data.Models;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Congo.WebApi.Data.ProductAccess
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
    {
        private readonly CongoContext _dbContext;
        public GetProductListHandler(CongoContext dbContext)
        {
            _dbContext = dbContext;
        }   
        public Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            // ToDo Implimend Method To call a list of Products from DB
            return Task.FromResult(new List<Product>());
        }

    }
}
