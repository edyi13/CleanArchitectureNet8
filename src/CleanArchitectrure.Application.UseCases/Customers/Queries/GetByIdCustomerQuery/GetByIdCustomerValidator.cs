using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
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
