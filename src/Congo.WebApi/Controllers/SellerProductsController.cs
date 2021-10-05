using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.WebApi.Data.ProductAccess;
using Congo.WebApi.Models.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Congo.WebApi.Controllers
{
    [ApiController]
    [Route("api/{seller}")]
    public class SellerProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SellerProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("products")]
        public async Task<ActionResult> Create(InsertProductRequest product)
        {
            var productId = await _mediator.Send(new InsertProductCommand
                (product.Name, product.Description, product.Price, product.ImageUrl));

            return Ok(productId);
        }

    }
}
