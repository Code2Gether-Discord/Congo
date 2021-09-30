using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Congo.WebApi.Commands;
using Congo.WebApi.Data.Models;
using System.Threading;
using Congo.WebApi.DataAccess;

namespace Congo.WebApi.Handlers
{
    public class InsertProductHander : IRequestHandler<InsertProductCommand, Product>
    {
        private readonly IDemoProductDataAccess _data;
        public InsertProductHander(IDemoProductDataAccess data)
        {
            _data = data;
        }
        public Task<Product> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertProduct(request.Name, request.Description, request.Price, request.ImageUrl));
        }
    }
}
