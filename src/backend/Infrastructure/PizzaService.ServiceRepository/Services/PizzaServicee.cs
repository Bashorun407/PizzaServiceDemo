using AutoMapper;
using PizzaService.Application.Common;
using PizzaService.Application.DTOs.DtoForCreation;
using PizzaService.Domain.Entities;
using PizzaService.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceRepository.Services
{
    internal sealed class PizzaServicee : IPizzaServicee
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PizzaServicee(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<PizzaDtoForDisplay> CreatePizza(PizzaDtoForCreation pizza)
        {
            var pizzaDetails = _mapper.Map<Pizza>(pizza);
            _repository.pizzaRepository.CreatePizza(pizzaDetails);
           await _repository.SaveAsync();

            var pizzaToReturn = _mapper.Map<PizzaDtoForDisplay>(pizzaDetails);
            return pizzaToReturn;
        }

        public async void DeletePizza(int id, bool trackChanges)
        {
            var pizzaToDelete = await _repository.pizzaRepository.GetByIdAsync(id, trackChanges);

            _repository.pizzaRepository.DeletePizza(pizzaToDelete);
            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<PizzaDtoForDisplay>> GetAllPizzaAsync(bool trackChanges)
        {
            var pizzaEntity = _repository.pizzaRepository.GetAllAsync(trackChanges);

            var pizzas = _mapper.Map<PizzaDtoForDisplay>(pizzaEntity);
            return (IEnumerable<PizzaDtoForDisplay>)pizzas;
        }

        public async Task<IEnumerable<PizzaDtoForDisplay>> GetAllPizzaBySizeAsync(double size, bool trackChanges)
        {
            var pizzaEntity = _repository.pizzaRepository.GetAllBySizeAsync(size, trackChanges);

            var pizzas = _mapper.Map<PizzaDtoForDisplay>(pizzaEntity);
            return (IEnumerable<PizzaDtoForDisplay>)pizzas;
        }

        public async Task<PizzaDtoForDisplay> GetPizzaById(int id, bool trackChanges)
        {
            var pizzaEntity = await _repository.pizzaRepository.GetByIdAsync(id, trackChanges);
            var pizzaToReturn = _mapper.Map<PizzaDtoForDisplay>(pizzaEntity);

            return pizzaToReturn;
        }

        public async void UpdatePizza(int id, PizzaDtoForUpdate pizza, bool trackChanges)
        {
            var pizzaEntity = await _repository.pizzaRepository.GetByIdAsync(id, trackChanges);
            //var pizzaDto = _mapper.Map<Pizza>(pizzaEntity);
            //pizzaEntity.ModifiedBy = pizzaDto.ModifiedBy;

            _mapper.Map(pizza, pizzaEntity);
            await _repository.SaveAsync();
        }

        public void UpdatePizza(int id, PizzaDtoForUpdate pizza)
        {
            throw new NotImplementedException();
        }
    }
}
