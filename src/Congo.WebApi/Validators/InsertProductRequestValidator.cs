using Congo.Contracts.Requests.Products;
using FluentValidation;

namespace Congo.WebApi.Validators;

public class InsertProductRequestValidator : AbstractValidator<InsertProductRequest>
{
    public InsertProductRequestValidator()
    {
        RuleFor(x => x.Name).NotNull();
        RuleFor(x => x.Price).InclusiveBetween(0, decimal.MaxValue);
    }
}