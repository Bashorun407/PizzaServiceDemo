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

        }
    }
}
