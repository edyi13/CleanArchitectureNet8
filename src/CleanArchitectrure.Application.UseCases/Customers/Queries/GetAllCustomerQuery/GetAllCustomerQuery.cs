using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectrure.Application.UseCases.Commons.Bases;
using CleanArchitectrure.Application.Dto;
using MediatR;

namespace CleanArchitectrure.Application.UseCases.Customers.Queries.GetAllCustomerQuery
{
    public class GetAllCustomerQuery: IRequest<BaseResponse<IEnumerable<CustomerDto>>>
    {
    }
}
