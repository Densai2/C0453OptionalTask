using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CO453_WebApplication1.Models
{
    public class PaymentDetails
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
        [Required, DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }
        [Required]
        public string ExpiryDate { get; set; }
        [Required]
        public string NameOnCard { get; set; }
        [Required]
        public string SecurityCode { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string City { get; set; }
        [Required, DataType(DataType.PostalCode)]
        public string PostCode { get; set; }
    }
}
