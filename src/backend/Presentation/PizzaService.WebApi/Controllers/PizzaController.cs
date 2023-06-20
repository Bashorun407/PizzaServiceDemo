using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaService.ServiceContracts.Common;

namespace PizzaService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public PizzaController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPizzas()
        {
            var pizzas = await _serviceManager.pizzaService.GetAllPizzaAsync(trackChanges: false);
            return Ok(pizzas);
        }
    }
}
