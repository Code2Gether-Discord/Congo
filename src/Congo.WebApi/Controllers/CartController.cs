using System;
using System.Collections.Generic;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartResponse>>> Get()
        {
            var carts = await _mediator.Send(new GetCartsQuery());
            return Ok(carts.Adapt<IEnumerable<CartResponse>>());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<IEnumerable<CartItemResponse>>> Get(Guid id)
        {
            var cartItems = await _mediator.Send(new GetCartItemsQuery(id));
            return Ok(cartItems.Adapt<IEnumerable<CartItemResponse>>());
        }
    }
}
