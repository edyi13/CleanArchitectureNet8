using FluentValidation;

namespace CleanArchitectrure.Application.UseCases.Customers.Queries.GetByIdCustomerQuery
{
    public class GetByIdCustomerValidator: AbstractValidator<GetByIdCustomerQuery>
    {
        public GetByIdCustomerValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5)
                .MaximumLength(5);
        }
    }
}
