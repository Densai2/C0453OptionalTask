using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CO453_WebApplication1.Models
{
    public class Menu
    {
        [Required]
        public string Starter { get; set; }
        [Required]
        public string Main { get; set; }
        [Required]
        public string Dessert { get; set; }
        [Required]
        public string Drink { get; set; }

    }
}
