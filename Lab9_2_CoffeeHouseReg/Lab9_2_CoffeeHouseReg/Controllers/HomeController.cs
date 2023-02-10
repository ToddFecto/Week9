using Dapper.Contrib.Extensions;
using Lab9_2_CoffeeHouseReg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab9_2_CoffeeHouseReg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult RegistrationThankYou(Registration registration)
        {
            if (registration.FirstName == null || registration.FirstName.Length < 2)
            {
                ViewData["Message"] = "***Please provide your full first name. Please try again.***";
                return View("Registration");
            }
            if (registration.LastName == null || registration.LastName.Length < 1)
            {
                ViewData["Message"] = "***Last name needs at least one character. Please try again.***";
                return View("Registration");
            }
            else if (registration.EmailAddress == null || !registration.EmailAddress.Contains("@"))
            {
                ViewData["Message"] = "***Please provide a valid email address.***";
                return View("Registration");
            }
            if (registration.Password == null || registration.Password.Length < 8)
            {
                ViewData["Message"] = "***Password needs at least eight characters. Please try again.***";
                return View("Registration");
            }
            else
            {
                return View(registration);
            }
        }

        public IActionResult products(int prds)
        {
            MySqlConnection db = new MySqlConnection("Server=localhost;Database=coffeehouse;Uid=root;Password=abc123");
            Products prods = db.Get<Products>(prds);
            return View(prods);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
