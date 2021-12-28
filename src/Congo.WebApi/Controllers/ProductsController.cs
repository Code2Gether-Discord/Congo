using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Congo.Contracts.Responses.Orders;
using Congo.Contracts.Responses.Products;
using Congo.WebApi.Data.ProductAccess;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Congo.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : Controller
{
    private readonly IMediator _mediator;

    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponse>>> GetAllProducts()
    {
        var products = await _mediator.Send(new GetProductListQuery());
        return Ok(products.Adapt<IEnumerable<ProductResponse>>());
    }

    [HttpPost("{id}/purchase")]
    public async Task<ActionResult<OrderConfirmationResponse>> PurchaseProductById(Guid id)
    {
        var orderConfirmation = await _mediator.Send(new PurchaseProductCommand(id));

        if (orderConfirmation == null) return BadRequest();

        return orderConfirmation;
    }
}