using PizzaService.Application.Common;
using PizzaService.Application.Contracts;
using PizzaService.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICustomerRepository> _customerRepository;
        private readonly Lazy<IOrderRepository> _orderRepository;
        private readonly Lazy<IPizzaRepository> _pizzaRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(repositoryContext));
            _orderRepository = new Lazy<IOrderRepository> (()=> new OrderRepository(repositoryContext));
            _pizzaRepository = new Lazy<IPizzaRepository> (()=> new PizzaRepository(repositoryContext));
        }

        public ICustomerRepository customerRepository => _customerRepository.Value;

        public IOrderRepository orderRepository => _orderRepository.Value;

        public IPizzaRepository pizzaRepository => _pizzaRepository.Value;

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}

