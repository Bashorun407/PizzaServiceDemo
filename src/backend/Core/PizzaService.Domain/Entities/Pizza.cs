using PizzaService.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaService.Domain.Entities
{
    public class Pizza : BaseEntity
    {
        [ForeignKey(nameof(Order))]
        public int Order_Id { get; set; }
        public double Size { get; set; }
    }
}
