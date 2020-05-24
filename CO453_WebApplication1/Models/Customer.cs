using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CO453_WebApplication1.Models
{
    /// <summary>
    /// Danny Grace Posh Nosh website
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required]

        public string FullName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

    } 
}
