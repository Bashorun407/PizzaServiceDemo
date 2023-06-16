using PizzaService.Application.DTOs.DtoForCreation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceContracts.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDtoForDisplay>> GetAllOrdersAsync(bool trackChanges);
        Task<IEnumerable<OrderDtoForDisplay>> GetAllOrdersByDate(DateTime date, bool trackChanges);
        Task<OrderDtoForDisplay> GetOrderByIdAsync(int id, bool trackChanges);
        void CreateOrder(OrderDtoForCreation order);
        void UpdateOrder(OrderDtoForDisplay order);
        void DeleteOrder(int id, bool trackChanges);
    }
}
