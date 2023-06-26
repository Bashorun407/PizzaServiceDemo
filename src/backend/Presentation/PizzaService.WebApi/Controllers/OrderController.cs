using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaService.Application.DTOs.DtoForCreation;
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

        [HttpGet]
        public async Task<IActionResult> GetOrderById(int id)
        {
            var order = await _serviceManager.orderService.GetOrderByIdAsync(id, trackChanges: false);
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderDtoForCreation orderDtoForCreation)
        {
            var order = await _serviceManager.orderService.CreateOrder(orderDtoForCreation);
            return Ok(order);
        }

        [HttpDelete]
        public async void DeleteOrder(int id)
        {
            _serviceManager.orderService.DeleteOrder(id, trackChanges: false);
        }

    }
}
