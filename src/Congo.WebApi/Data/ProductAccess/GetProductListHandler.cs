using Congo.WebApi.Data.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Congo.WebApi.Data.ProductAccess
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
    {
            private readonly CongoContext _data;
            public GetProductListHandler(CongoContext data)
            {
                _data = data;
            }
            public Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
            {
            // ToDo Implimend Method To call a list of Products from DB
            return Task.FromResult(new List<Product>());
            }

    }
}
