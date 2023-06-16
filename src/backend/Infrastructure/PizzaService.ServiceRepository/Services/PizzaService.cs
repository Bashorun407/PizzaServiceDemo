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
    internal sealed class PizzaService : IPizzaService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PizzaService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public void CreatePizza(PizzaDtoForCreation pizza)
        {
            throw new NotImplementedException();
        }

        public void DeletePizza(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PizzaDtoForDisplay>> GetAllPizzaAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PizzaDtoForDisplay>> GetAllPizzaBySizeAsync(double size, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<PizzaDtoForDisplay> GetPizzaById(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdatePizza(int id, PizzaDtoForUpdate pizza)
        {
            throw new NotImplementedException();
        }
    }
}
