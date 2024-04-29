using CleanArchitectrure.Application.UseCases.Commons.Bases;
using MediatR;

namespace CleanArchitectrure.Application.UseCases.Customers.Commands.DeleteCustomerCommand
{
    public class DeleteCustomerCommand: IRequest<BaseResponse<bool>>
    {
        public string CustomerId { get; set; }
    }
}
