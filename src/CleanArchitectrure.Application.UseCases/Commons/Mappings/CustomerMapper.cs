using AutoMapper;
using CleanArchitectrure.Application.Dto;
using CleanArchitectrure.Application.UseCases.Customers.Commands.CreateCustomerCommand;
using CleanArchitectrure.Application.UseCases.Customers.Commands.UpdateCustomerCommand;
using CleanArchitectrure.Domain.Entities;

namespace CleanArchitectrure.Application.UseCases.Commons.Mappings
{
    public class CustomerMapper: Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<Customer, CreateCustomerCommand>().ReverseMap();
            CreateMap<Customer, UpdateCustomerCommand>().ReverseMap();
        }
    }
}
