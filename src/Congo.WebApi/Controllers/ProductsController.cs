using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.Contracts.Responses.Products;
using Congo.WebApi.Data.ProductAccess;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Congo.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;


        public ProductsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ProductResponse>> Get()
        {
            var products = await _mediator.Send(new GetProductListQuery());
            return Ok(_mapper.Map<ProductResponse[]>(products));
        }

        [HttpPost("{id}/purchase")]
        public ActionResult<OrderConfirmationResponse> Purchase(Guid id)
        {
            var orderId = Guid.NewGuid();

            return new OrderConfirmationResponse { OrderId = orderId };
        }
    }
}
