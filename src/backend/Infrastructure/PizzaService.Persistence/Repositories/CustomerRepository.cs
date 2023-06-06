using Microsoft.EntityFrameworkCore;
using PizzaService.Application.Contracts;
using PizzaService.Domain.Entities;
using PizzaService.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Persistence.Repositories
{
    internal sealed class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        protected RepositoryContext _repositoryContext;
        public CustomerRepository(RepositoryContext repositoryContext) : base(repositoryContext) 
        {

        }
        public void CreateCustomer(Customer customer)
        {
            Create(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Delete(customer);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync(bool trackChanges)
        {
            return await FindAll(trackChanges)
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async Task<Customer> GetByPhoneNumberAsync(string phoneNumber, bool trackChanges)
        {
            return await FindByCondition(x => x.Customer_PhoneNumber == phoneNumber, trackChanges)
                .FirstOrDefaultAsync();
        }

        public void UpdateCustomer(Customer customer)
        {
            Update(customer);
        }
    }
}
