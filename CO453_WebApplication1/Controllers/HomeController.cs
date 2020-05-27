using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CO453_WebApplication1.Models;

namespace CO453_WebApplication1.Controllers
{
    /// <summary>
    /// Danny Grace Posh Nosh website
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Customer()
        {
            Customer customer = new Customer
            {
                CustomerID = 1,
                FullName = "Daniel",
                Address = "Hp430op",
                Email = "danielgrace@gmail.com",
                PhoneNumber = "061234 567 345"
            };
            return View(customer);
        }
        [HttpPost]
        public IActionResult Customer(Customer customer)
        {
            //Save to database
            ViewData["Customer"] = customer;
            ViewBag.Customer = customer;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PaymentDetails()
        {
            PaymentDetails payment = new PaymentDetails
            {
                FirstName = "Daniel",
                SecondName = "Grace",
                Email = "danielgrace@gmail.com",
                DateOfBirth = "02/11/2000",
                CardNumber = "373157862558357",
                ExpiryDate = "04/24",
                NameOnCard = "Daniel",
                SecurityCode = "742",
                StreetName = "Manor road",
                City = "Aylesbury",
                PostCode = "HP55 1JO"
            };
            return View(payment);
        }

        [HttpPost]
        public IActionResult PaymentDetails(PaymentDetails payment)
        {
            //Save to database
            ViewData["Payment details"] = payment;
            ViewBag.Payment = payment;

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Menu()
        {
            Menu menu = new Menu
            {
                Starter = "Garlic bread",
                Main = "Tomato pasta",
                Dessert = "Chocolate cake",
                Drink = "Red wine"

            };
            return View(menu);
        }
        [HttpPost]
        public IActionResult Menu (Menu menu)
        {
            ViewData["Menu"] = menu;
            ViewBag.Menu = menu;

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
