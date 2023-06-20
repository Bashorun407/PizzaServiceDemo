using PizzaService.ServiceContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.ServiceContracts.Common
{
    public interface IServiceManager
    {
        public ICustomerService customerService { get;  }
        public IOrderService orderService { get;  }
        public IPizzaServicee pizzaService { get;  }
    }
}
