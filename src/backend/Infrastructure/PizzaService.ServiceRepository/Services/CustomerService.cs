using AutoMapper;
using PizzaService.Application.Common;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Application.DTOs.DtoForDisplay;
using PizzaService.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceRepository.Services
{
    internal sealed class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
 
        public CustomerService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public void CreateCustomer(CustomerDtoForCreation customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerDtoForDisplay>> GetAllCustomersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerDtoForDisplay> GetCustomersAsync(string phoneNumber, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(string phoneNumber, CustomerDtoForUpdate customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, CustomerDtoForUpdate customer)
        {
            throw new NotImplementedException();
        }
    }
}
