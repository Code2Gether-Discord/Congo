using Congo.WebApi.Data;
using Congo.WebApi.Data.Models;
using Congo.WebApi.Data.ProductAccess;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Congo.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoProductController : Controller
    {
        // THIS IS PURELY FOR DEMO PURPOSES 
        private readonly IMediator _mediator; // We create this so we can inject the mediatr service when the project is first built
        public DemoProductController(IMediator mediator)
        {
           _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await _mediator.Send(new GetProductListQuery());
        }

    }
}
