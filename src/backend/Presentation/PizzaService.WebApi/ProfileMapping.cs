using AutoMapper;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Application.DTOs.DtoForDisplay;
using PizzaService.Domain.Entities;

namespace PizzaService.WebApi
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<Customer, CustomerDtoForDisplay>();
            CreateMap<CustomerDtoForCreation, Customer>();
            CreateMap<CustomerDtoForUpdate, Customer>();

            CreateMap<Order, OrderDtoForDisplay>();
            CreateMap<OrderDtoForCreation, Order>();
            CreateMap<OrderDtoForUpdate, Order>();

            CreateMap<Pizza,  PizzaDtoForDisplay>();
            CreateMap<PizzaDtoForCreation, Pizza>();
            CreateMap<PizzaDtoForUpdate, Pizza>();

        }
    }
}
