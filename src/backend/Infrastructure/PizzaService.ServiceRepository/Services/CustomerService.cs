using AutoMapper;
using PizzaService.Application.Common;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Application.DTOs.DtoForDisplay;
using PizzaService.Domain.Entities;
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

        public async Task<CustomerDtoForDisplay> CreateCustomer(CustomerDtoForCreation customerDto)
        {
            var customerEntity = _mapper.Map<Customer>(customerDto);
            _repository.customerRepository.CreateCustomer(customerEntity);
           await _repository.SaveAsync();

            var customerToReturn = _mapper.Map<CustomerDtoForDisplay>(customerEntity);

            return customerToReturn;
        }


        public void DeleteCustomer(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerDtoForDisplay>> GetAllCustomersAsync(bool trackChanges)
        {
            var getCustomersEntities = await _repository.customerRepository.GetAllAsync(trackChanges);
            var customerEntities = _mapper.Map<IEnumerable<CustomerDtoForDisplay>>(getCustomersEntities);
            return customerEntities;
        }

        public async Task<CustomerDtoForDisplay> GetCustomersAsync(string phoneNumber, bool trackChanges)
        {
            var getCustomer = await _repository.customerRepository.GetByPhoneNumberAsync(phoneNumber, trackChanges);
            var customer = _mapper.Map<CustomerDtoForDisplay>(getCustomer);
            return customer;
        }

        public void UpdateCustomer(string phoneNumber, CustomerDtoForUpdate customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int id, CustomerDtoForUpdate customer)
        {
            throw new NotImplementedException();
        }

        Task<CustomerDtoForDisplay> ICustomerService.UpdateCustomer(int id, CustomerDtoForUpdate customer)
        {
            throw new NotImplementedException();
        }
    }
}
