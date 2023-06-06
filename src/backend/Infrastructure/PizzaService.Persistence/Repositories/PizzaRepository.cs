using Microsoft.EntityFrameworkCore;
using PizzaService.Application.Contracts;
using PizzaService.Domain.Entities;
using PizzaService.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Persistence.Repositories
{
    internal sealed class PizzaRepository : RepositoryBase<Pizza>, IPizzaRepository
    {
        public PizzaRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
        public void CreatePizza(Pizza pizza)
        {
            Create(pizza);
        }

        public void DeletePizza(Pizza pizza)
        {
            Delete(pizza);
        }

        public async Task<IEnumerable<Pizza>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Pizza>> GetAllBySizeAsync(double size, bool trackChanges)
        {
            return await FindByCondition(x=>x.Size == size, trackChanges)
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async Task<Pizza> GetByIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(x => x.Id == id, trackChanges)
                .FirstOrDefaultAsync();
        }

        public void UpdatePizza(Pizza pizza)
        {
            Update(pizza);
        }
    }
}
