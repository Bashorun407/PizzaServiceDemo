using PizzaService.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Domain.Entities
{
    public class Order : BaseEntity
    {
        [ForeignKey(nameof(Customer))]
        public int Customer_Id { get; set; }
        public DateTime Order_Date { get; set; }
        public double Total_Amount { get; set; }
        public string? Status { get; set; }
    }
}

