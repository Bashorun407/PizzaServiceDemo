using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Application.DTOs.DtoForDisplay;
using PizzaService.ServiceContracts.Common;

namespace PizzaService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public CustomerController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _serviceManager.customerService.GetAllCustomersAsync(trackChanges: false);
            return Ok(customers);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerDtoForCreation customerDtoForCreation)
        {
          CustomerDtoForDisplay customer =  await _serviceManager.customerService.CreateCustomer(customerDtoForCreation);
            return Ok(customer);
        }

        [HttpDelete]
        public async Task DeleteCustomer(int id)
        {
            _serviceManager.customerService.DeleteCustomer(id, trackChanges: false);
        }


        [HttpGet]
        public async Task<IActionResult> GetCustomerById(string phoneNumber)
        {
            var customer = await _serviceManager.customerService.GetCustomersAsync(phoneNumber, trackChanges: false);
            return Ok(customer);
        }

        [HttpPut]
        public async Task UpdateCustomer(int id, CustomerDtoForUpdate customerDtoForUpdate)
        {
             _serviceManager.customerService.UpdateCustomer(id, customerDtoForUpdate);
        }

    }
}
