using Congo.WebApi.Contracts.Responses;
using Congo.WebApi.Data;
using Congo.WebApi.Data.Models;
using Congo.WebApi.Data.ProductAccess;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Congo.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoProductController : Controller
    {
        // THIS IS PURELY FOR DEMO PURPOSES 
        private readonly IMediator _mediator;

        public DemoProductController(IMediator mediator)
        {
           _mediator = mediator;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _mediator.Send(new GetProductListQuery());
        }

        [HttpPost("{id}/purchase")]
        public ActionResult<OrderConfirmationResponse> Purchase(Guid id)
        {
            var orderId = Guid.NewGuid();

            return new OrderConfirmationResponse { OrderId = orderId };
        }
    }
}
