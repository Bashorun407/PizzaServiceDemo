using AutoMapper;
using Microsoft.Extensions.Logging;
using PizzaService.Application.Common;
using PizzaService.ServiceContracts.Common;
using PizzaService.ServiceContracts.Interfaces;
using PizzaService.ServiceRepository.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceRepository.Common
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICustomerService> _customerService;
        private readonly Lazy<IOrderService> _orderService;
        private readonly Lazy<IPizzaServicee> _pizzaService;

        public ServiceManager( IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _customerService = new Lazy<ICustomerService>(
                () => new CustomerService(repositoryManager, logger, mapper));

            _orderService = new Lazy<IOrderService>( 
                () => new OrderService(repositoryManager, logger,mapper));

            _pizzaService = new Lazy<IPizzaServicee>(
                () => new PizzaServicee(repositoryManager, logger, mapper));
        }

        public ICustomerService customerService { get => _customerService.Value; }
        public IOrderService orderService { get => _orderService.Value; }
        public IPizzaServicee pizzaService { get => _pizzaService.Value; }
    }
}
