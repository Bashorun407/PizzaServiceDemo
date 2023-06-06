using Microsoft.EntityFrameworkCore;
using PizzaService.Application.Contracts;
using PizzaService.Domain.Entities;
using PizzaService.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Persistence.Repositories
{
    internal sealed class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            
        }
        public void CreateOrder(Order order)
        {
            Create(order);
        }

        public void DeleteOrder(Order order)
        {
            Delete(order);
        }

        public async Task<IEnumerable<Order>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetByOrderDateAsync(DateTime dateTime, bool trackChanges)
        {
            return await FindByCondition(x=>x.Order_Date == dateTime, trackChanges)
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task<Order> GetByOrderIdAsync(int id, bool trackChanges)
        {
            return await FindByCondition(x => x.Id == id, trackChanges)
                .FirstOrDefaultAsync();
        }

        public void UpdateOrder(Order order)
        {
            Update(order);
        }
    }
}
