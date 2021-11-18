using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;
using Congo.WebApi.Data.CartAccess;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Congo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator) => _mediator = mediator;


        [HttpGet("{id}")]
        public async Task<ActionResult<CartResponse>> GetCartById(Guid id)
        {
            var cart = await _mediator.Send(new GetCartQuery(id));
            return Ok(cart.Adapt<CartResponse>());
        }
    }
}
