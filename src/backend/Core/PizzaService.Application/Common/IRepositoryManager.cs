using PizzaService.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Application.Common
{
    public interface IRepositoryManager
    {
        ICustomerRepository customerRepository { get; }
        IOrderRepository orderRepository { get; }
        IPizzaRepository pizzaRepository { get; }
        Task SaveAsync();
    }
}

