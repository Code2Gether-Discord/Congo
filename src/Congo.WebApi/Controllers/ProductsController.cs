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
        // THIS IS PURELY FOR DEMO PURPOSES 
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
        public ActionResult<Product> Create(ProductInputModel product)
        {
            if (!ModelState.IsValid)
            {
                return ValidationProblem(ModelState);
            }

            var productResult = _mediator.Send(new InsertProductCommand
                (product.Name, product.Description, product.Price, product.ImageUrl)).Result;

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
