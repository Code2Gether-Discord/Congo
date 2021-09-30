using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Queries
{
    public record GetProductListQuery: IRequest<List<Product>>;
}
