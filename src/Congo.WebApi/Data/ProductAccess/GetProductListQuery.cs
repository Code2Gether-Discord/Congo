using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Congo.WebApi.Data.Models;

namespace Congo.WebApi.Data.ProductAccess
{
    public record GetProductListQuery(): IRequest<List<Product>>;
    
}
