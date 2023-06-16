using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Application.DTOs.DtoForDisplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceContracts.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDtoForDisplay>> GetAllCustomersAsync(bool trackChanges);
        Task<CustomerDtoForDisplay> GetCustomersAsync(string phoneNumber, bool trackChanges);
        Task<CustomerDtoForDisplay> CreateCustomer(CustomerDtoForCreation customer);
        Task<CustomerDtoForDisplay> UpdateCustomer(int id, CustomerDtoForUpdate customer);
        void DeleteCustomer(int id, bool trackChanges);
    }
}
