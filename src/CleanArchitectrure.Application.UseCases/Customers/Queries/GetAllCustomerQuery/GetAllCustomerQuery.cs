using CleanArchitectrure.Application.Dto;
using CleanArchitectrure.Application.UseCases.Commons.Bases;
using MediatR;

namespace CleanArchitectrure.Application.UseCases.Customers.Queries.GetAllCustomerQuery
{
    public class GetAllCustomerQuery: IRequest<BaseResponse<IEnumerable<CustomerDto>>>
    {
    }
}
