using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Application.DTOs.DtoForDisplay
{
    public class CustomerDtoForDisplay
    {
        public string? Customer_FirstName { get; set; }
        public string? Customer_LastName { get; set; }
        public string? Customer_Email { get; set; }
        public string? Customer_PhoneNumber { get; set; }
        public string? Customer_Address { get; set; }

    }
}
