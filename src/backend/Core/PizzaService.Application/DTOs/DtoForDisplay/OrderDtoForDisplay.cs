using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Application.DTOs.DtoForCreation
{
    public class OrderDtoForDisplay
    {
        public DateTime Order_Date { get; set; }
        public double Total_Amount { get; set; }
        public string? Status { get; set; }

    }
}
