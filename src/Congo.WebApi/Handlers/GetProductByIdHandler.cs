using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using Congo.WebApi.DataAccess;
using Congo.WebApi.Queries;
using MediatR;

namespace Congo.WebApi.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IMediator _mediator;

        //Example of a mediatr item calling another mediatr to return single result.

        public GetProductByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetProductListQuery());
            var output = results.FirstOrDefault(x => x.Id == request.Id);
            return output;
        }
    }
}
