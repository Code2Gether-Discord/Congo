using System;

namespace Congo.Contracts.Responses.Orders
{
    public sealed class OrderConfirmationResponse
    {
        public Guid OrderId { get; init; }
    }
}
