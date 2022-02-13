using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;
using Congo.WebApi.Data.CartAccess;
using Congo.WebApi.Data.Models;
using Congo.WebApi.Requests.Cart;
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
        public async Task<ActionResult<CartResponse>> GetCartById(Guid id)
        {
            var cart = await _mediator.Send(new GetCartQuery(id));
            return Ok(cart.Adapt<CartResponse>());
        }

        [HttpPost("add-to-cart")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(CartResponse), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<CartResponse>> AddToCart(AddToCartRequest request)
        {
            var cart = await _mediator.Send(new AddToCartCommand(CurrentCartId, request.ProductId, request.Quantity));

            if (cart == null)
                return BadRequest();
            else if (!cart.IsNewCart)
                return NoContent();

            return Ok(cart.Adapt<CartResponse>());
        }

        private Guid? CurrentCartId
        {
            get
            {
                if (Guid.TryParse(HttpContext.Request.Cookies["cart_id"], out var cartId))
                    return cartId;
                return null;
            }
        }
    }
}
