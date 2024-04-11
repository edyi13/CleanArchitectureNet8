using CleanArchitectrure.Application.UseCases.Commons.Bases;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectrure.Application.UseCases.Customers.Commands.DeleteCustomerCommand
{
    public class DeleteCustomerCommand: IRequest<BaseResponse<bool>>
    {
        public string CustomerId { get; set; }
    }
}
