using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using Congo.WebApi.DataAccess;
using Congo.WebApi.Queries;
using MediatR;
namespace Congo.WebApi.Handlers
{
    public class GetProductListHandler : IRequestHandler<GetProductListQuery, List<Product>>
    {
        private readonly IDemoProductDataAccess _data;
        public GetProductListHandler(IDemoProductDataAccess data)
        {
            _data = data;
        }
        public Task<List<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetProducts());
        }
    }
}
