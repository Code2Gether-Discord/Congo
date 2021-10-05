using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Data.ProductAccess
{
    public class InsertProductHandler : IRequestHandler<InsertProductCommand, Guid>
    {
        private readonly CongoContext _dbContext;

        public InsertProductHandler(CongoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(InsertProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Price = request.Price
            };

            _dbContext.Products.Add(product);

            await _dbContext.SaveChangesAsync();

            return product.Id;
        }
    }
}
