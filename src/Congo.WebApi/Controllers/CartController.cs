using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;
using Congo.WebApi.Data.CartAccess;
using Congo.WebApi.Data.Models;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Congo.WebApi.Data.CartAccess.CartCommands;

namespace Congo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CartController(IMediator mediator) => _mediator = mediator;

        [HttpGet("{id}")]
        public async Task<ActionResult<CartResponse>> Get(Guid id)
        {
            var cart = await _mediator.Send(new GetCartQuery(id));
            return Ok(cart.Adapt<CartResponse>());
        }

        [HttpPost("{cartId}")]
        public async Task<ActionResult<Cart>> Post(Guid? cartId, Product product)
        {
            var cart = await _mediator.Send(new AddToCartCommand(cartId, product));
            return Ok(cart.Adapt<Cart>());
        }
    }
}
