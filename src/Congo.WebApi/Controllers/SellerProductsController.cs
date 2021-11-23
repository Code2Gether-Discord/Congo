using System;
using System.Threading.Tasks;
using Congo.Contracts.Requests.Products;
using Congo.WebApi.Data.ProductAccess;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Congo.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SellerProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SellerProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("products")]
        public async Task<ActionResult<Guid>> CreateProduct(InsertProductRequest product)
        {
            var productId = await _mediator.Send(new InsertProductCommand
                (product.Name, product.Description, product.Price, product.ImageUrl));

            return productId;
        }
    }
}
