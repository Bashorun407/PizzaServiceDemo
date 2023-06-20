using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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
    }
}
