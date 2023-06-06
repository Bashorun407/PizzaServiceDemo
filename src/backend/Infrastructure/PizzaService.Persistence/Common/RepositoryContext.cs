using Microsoft.EntityFrameworkCore;
using PizzaService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Persistence.Common
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }

        //Doing a DbSet for all the entities here
       public DbSet<Customer> Customers { get; set; }
       public DbSet<Order> Orders { get; set; }
       public DbSet<Pizza> Pizzas { get; set; }
    }
}
