using System;
using Congo.Contracts.Responses.Orders;
using MediatR;

namespace Congo.WebApi.Data.ProductAccess
{
    public record InsertProductCommand(string Name, string Description, decimal Price, string ImageUrl) : IRequest<Guid>;
    public record PurchaseProductCommand(Guid Id) : IRequest<OrderConfirmationResponse>;
}
