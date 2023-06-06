using PizzaService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Application.Contracts
{
    public interface IPizzaRepository
    {
        Task<IEnumerable<Pizza>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<Pizza>> GetAllBySizeAsync(double size, bool trackChanges);
        Task<Pizza> GetByIdAsync(int id, bool trackChanges);
        void CreatePizza(Pizza pizza);
        void UpdatePizza(Pizza pizza);
        void DeletePizza(Pizza pizza);
    }
}
