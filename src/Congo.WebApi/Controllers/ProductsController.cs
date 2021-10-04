using Congo.WebApi.Contracts.Responses;
using Congo.WebApi.Data;
using Congo.WebApi.Data.Models;
using Congo.WebApi.Data.ProductAccess;
using Congo.WebApi.Models.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Congo.WebApi.Controllers
{
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
        public async Task<IEnumerable<Product>> Get()
        {
            return await _mediator.Send(new GetProductListQuery());
        }


        [HttpPost]
        [Route("~/api/{seller}/products")]
        public async Task<ActionResult> Create(InsertProductRequest product)
        {
            var productResult = await _mediator.Send(new InsertProductCommand
                (product.Name, product.Description, product.Price, product.ImageUrl));

            return Ok(productResult);
        }

        [HttpPost("{id}/purchase")]
        public ActionResult<OrderConfirmationResponse> Purchase(Guid id)
        {
            var orderId = Guid.NewGuid();

            return new OrderConfirmationResponse { OrderId = orderId };
        }
    }
}
