using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaService.ServiceContracts.Common;

namespace PizzaService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public OrderController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _serviceManager.orderService.GetAllOrdersAsync(trackChanges: false);
            return Ok(orders);
        }
    }
}
