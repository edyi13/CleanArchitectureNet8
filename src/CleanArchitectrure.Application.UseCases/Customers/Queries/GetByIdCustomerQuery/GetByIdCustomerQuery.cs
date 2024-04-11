using CleanArchitectrure.Application.Dto;
using CleanArchitectrure.Application.UseCases.Commons.Bases;
using MediatR;

namespace CleanArchitectrure.Application.UseCases.Customers.Queries.GetByIdCustomerQuery
{
    public class GetByIdCustomerQuery: IRequest<BaseResponse<CustomerDto>>
    {
        public string? CustomerId { get; set; }
    }
}
