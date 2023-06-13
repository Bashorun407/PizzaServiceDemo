using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaService.Application.DTOs.DtoForCreation
{
    public class CustomerDtoForCreation
    {
        [MaxLength(25, ErrorMessage ="Maximum length for name is 25 characters")]
        [Required]
        public string? Customer_FirstName { get; set; }
        [MaxLength(25, ErrorMessage = "Maximum length for name is 25 characters")]
        [Required]
        public string? Customer_LastName { get; set; }
        [MaxLength(25, ErrorMessage = "Maximum length for name is 25 characters"), DataType(DataType.EmailAddress)]
        public string? Customer_Email { get; set; }
        [MaxLength(14, ErrorMessage = "Maximum length for name is 14 characters"), DataType(DataType.PhoneNumber)]
        public string? Customer_PhoneNumber { get; set; }
        [MaxLength(200, ErrorMessage = "Maximum length for name is 200 characters")]
        public string? Customer_Address { get; set; }

    }
}
