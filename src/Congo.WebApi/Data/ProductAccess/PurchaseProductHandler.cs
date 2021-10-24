using System.Threading;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.WebApi.Data.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Congo.WebApi.Data.ProductAccess
{
    public class PurchaseProductHandler : IRequestHandler<PurchaseProductCommand, OrderConfirmationResponse>
    {
        private readonly CongoContext _dbContext;

        public PurchaseProductHandler(CongoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<OrderConfirmationResponse> Handle(PurchaseProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == request.Id);

            var order = new Order();
            order.OrderItems.Add(new OrderItem
            {
                Price = product.Price,
                Amount = 1,
                ProductId = product.Id
            });

            _dbContext.Orders.Add(order);

            await _dbContext.SaveChangesAsync();

            return new OrderConfirmationResponse { OrderId = order.Id };
        }
    }
}
