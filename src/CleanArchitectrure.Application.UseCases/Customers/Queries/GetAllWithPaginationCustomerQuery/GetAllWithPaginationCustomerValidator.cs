using FluentValidation;

namespace CleanArchitectrure.Application.UseCases.Customers.Queries.GetAllWithPaginationCustomerQuery
{
    public class GetAllWithPaginationCustomerValidator : AbstractValidator<GetAllWithPaginationCustomerQuery>
    {
        public GetAllWithPaginationCustomerValidator()
        {
            RuleFor(x => x.PageNumber)
                .GreaterThanOrEqualTo(1)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.PageSize)
                .GreaterThanOrEqualTo(1)
                .NotNull()
                .NotEmpty();
        }
    }
}
