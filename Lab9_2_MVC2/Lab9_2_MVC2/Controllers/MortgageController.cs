using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab9_2_MVC2.Models;

namespace Lab9_2_MVC2.Controllers
{
    public class MortgageController : Controller
    {
        public IActionResult Index()
        {
            return Content("This is my index page.");
        }

        public IActionResult Welcome()
        {
            return Content("Welcome to my second mortgage system!");
        }

        public IActionResult MyPage()
        {
            ViewData["FirstName"] = "Tom";
            ViewData["LastName"] = "Jones";

            return View();
        }

        public IActionResult SignUpForm()
        {
            return View();
        }

        public IActionResult Thankyou(Customer cust)
        {
            ViewData["Customer"] = cust;
           
            return View(cust);
        }
    }
}
