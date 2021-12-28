using System;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Cart;
using Congo.WebApi.Data.CartAccess;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Congo.WebApi.Data.CartAccess.CartCommands;

namespace Congo.WebApi.Controllers;

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

    [HttpPost("/add-to-cart")]
    [ProducesResponseType(204)]
    [ProducesResponseType(typeof(Guid), 200)]
    public async Task<ActionResult> AddToCart(Guid? cartId, Guid productId, int quantity)
    {
        var cart = await _mediator.Send(new AddToCartCommand(cartId, productId, quantity));
        if (cart == Guid.Empty)
            return BadRequest();
        return Ok(cart);
    }
}