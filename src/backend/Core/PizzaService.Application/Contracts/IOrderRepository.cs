using PizzaService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Application.Contracts
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetAllAsync(bool trackChanges);
        Task<IEnumerable<Order>> GetByOrderDateAsync(DateTime dateTime, bool trackChanges);
        Task<Order> GetByOrderIdAsync(int id, bool trackChanges);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}


