using AutoMapper;
using PizzaService.Application.Common;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Application.DTOs.DtoForDisplay;
using PizzaService.Domain.Entities;
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

        public async Task<OrderDtoForDisplay> CreateOrder(OrderDtoForCreation order)
        {
            var orderDetails = _mapper.Map<Order>(order);
            _repository.orderRepository.CreateOrder(orderDetails);
           await _repository.SaveAsync();

            var orderToReturn = _mapper.Map<OrderDtoForDisplay>(orderDetails);
            return orderToReturn;
        }

        public  async void DeleteOrder(int id, bool trackChanges)
        {
            var orderToDelete = await _repository.orderRepository.GetByOrderIdAsync(id, trackChanges);

            _repository.orderRepository.DeleteOrder(orderToDelete);
           await _repository.SaveAsync();
            
        }

        public async Task<IEnumerable<OrderDtoForDisplay>> GetAllOrdersAsync(bool trackChanges)
        {
            var orderEntity = await _repository.orderRepository.GetAllAsync(trackChanges);

            var orders = _mapper.Map<OrderDtoForDisplay>(orderEntity);
            return (IEnumerable<OrderDtoForDisplay>) orders;
        }

        public async Task<IEnumerable<OrderDtoForDisplay>> GetAllOrdersByDate(DateTime date, bool trackChanges)
        {
            var orderEntity = await _repository.orderRepository.GetByOrderDateAsync(date, trackChanges);

            var orders = _mapper.Map<OrderDtoForDisplay>(orderEntity);
            return (IEnumerable<OrderDtoForDisplay>)orders;
        }
         
        public async Task<OrderDtoForDisplay> GetOrderByIdAsync(int id, bool trackChanges)
        {
            var orderEntity = await _repository.orderRepository.GetByOrderIdAsync(id, trackChanges);
            var orderToReturn = _mapper.Map<OrderDtoForDisplay>(orderEntity);

            return orderToReturn;
        }

        public async void UpdateOrder(int id, OrderDtoForUpdate order, bool trackChanges)
        {
            var orderEntity = await _repository.orderRepository.GetByOrderIdAsync(id, trackChanges);
            //var orderDto = _mapper.Map<Order>(order);

            _mapper.Map(order, orderEntity);
            //orderEntity.ModifiedBy = orderDto.ModifiedBy;

           await _repository.SaveAsync();

        }

        public void UpdateOrder(int id, OrderDtoForUpdate order)
        {
            throw new NotImplementedException();
        }
    }
}
