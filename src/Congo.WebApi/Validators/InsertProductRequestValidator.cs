using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Congo.Contracts.Requests.Products;
using FluentValidation;

namespace Congo.WebApi.Validators
{
    public class InsertProductRequestValidator : AbstractValidator<InsertProductRequest>
    {
        public InsertProductRequestValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Price).InclusiveBetween(0, decimal.MaxValue);
        }
    }
}
