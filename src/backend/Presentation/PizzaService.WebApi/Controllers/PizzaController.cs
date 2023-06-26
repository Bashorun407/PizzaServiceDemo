using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaService.Application.DTOs.DtoForCreation;
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

        [HttpGet]
        public async Task<IActionResult> GetPizzaById(int id)
        {
            var pizza = await _serviceManager.pizzaService.GetPizzaById(id, trackChanges: false);
            return Ok(pizza);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePizza(PizzaDtoForCreation pizzaDto)
        {
            var pizzaCreated = await _serviceManager.pizzaService.CreatePizza(pizzaDto);
            return Ok(pizzaCreated);
        }

        [HttpDelete]
        public void DeletePizzaById(int id)
        {
            _serviceManager.pizzaService.DeletePizza(id, trackChanges: false);
        }
    }
}
