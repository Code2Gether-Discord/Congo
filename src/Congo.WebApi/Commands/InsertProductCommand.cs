using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.WebApi.Data.Models;
using MediatR;

namespace Congo.WebApi.Commands
{
    public record InsertProductCommand(string Name, string Description, decimal Price, string ImageUrl) :IRequest<Product>;
    
}
