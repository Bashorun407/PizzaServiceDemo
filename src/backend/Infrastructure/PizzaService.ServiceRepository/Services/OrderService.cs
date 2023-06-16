using AutoMapper;
using PizzaService.Application.Common;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceRepository.Services
{
    internal sealed class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public OrderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public void CreateOrder(OrderDtoForCreation order)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDtoForDisplay>> GetAllOrdersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderDtoForDisplay>> GetAllOrdersByDate(DateTime date, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDtoForDisplay> GetOrderByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(OrderDtoForDisplay order)
        {
            throw new NotImplementedException();
        }
    }
}
