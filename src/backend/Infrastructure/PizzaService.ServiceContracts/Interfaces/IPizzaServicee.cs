using PizzaService.Application.DTOs.DtoForCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceContracts.Interfaces
{
    public interface IPizzaServicee
    {
        Task<IEnumerable<PizzaDtoForDisplay>> GetAllPizzaAsync(bool trackChanges);
        Task<IEnumerable<PizzaDtoForDisplay>> GetAllPizzaBySizeAsync(double size, bool trackChanges);
        Task<PizzaDtoForDisplay> GetPizzaById(int id, bool trackChanges);
        Task<PizzaDtoForDisplay> CreatePizza(PizzaDtoForCreation pizza);
        void UpdatePizza(int id, PizzaDtoForUpdate pizza);
        void DeletePizza(int id, bool trackChanges);
    }
}
