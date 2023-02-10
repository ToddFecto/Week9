using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment6_FoC_PotLuck_Series.Models;

namespace Assessment6_FoC_PotLuck_Series.Controllers
{
    public class FoCPotluckSeries : Controller
    {
        public IActionResult Home()
        {
            ViewData["Message"] = "";
            return View();
        }

        public IActionResult RSVP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RSVPThankYou(RSVP rSVP)
        {
            if (rSVP.FirstName == null || rSVP.FirstName.Length < 2)
            {
                ViewData["Message"] = "***Please provide your full first name. Please try again.***";
                return View("RSVP");
            }
            if (rSVP.LastName == null || rSVP.LastName.Length < 1)
            {
                ViewData["Message"] = "***Last name needs at least one character. Please try again.***";
                return View("RSVP");
            }
            else if (rSVP.EmailAddress == null || !rSVP.EmailAddress.Contains("@"))
            {
                ViewData["Message"] = "***Please provide a valid email address.***";
                return View("RSVP");
            }
            else if (rSVP.DateAttending == null)
            {
                ViewData["Message"] = "***Please choose a date to attend.***";
                return View("RSVP");
            }
            else if (rSVP.GuestName == null)
            {
                ViewData["Message"] = "***Please provide a guest name or enter 'NA' if attending alone.***";
                return View("RSVP");
            }
            else
            {
                return View(rSVP);
            }
        }

        public IActionResult BringADish()
        {
            return View();
        }

        [HttpPost]

        public IActionResult DishThankYou(BringADish bringADish)
        {
            if (bringADish.Name == null)
            {
                ViewData["Message"] = "***Please fill in the name field.***";
                return View("BringADish");
            }
            else if (bringADish.Category == null)
            {
                ViewData["Message"] = "***Please choose a Category for a dish.***";
                return View("BringADish");
            }
            else if (bringADish.DishName == null || bringADish.DishName.Length < 2)
            {
                ViewData["Message"] = "***Please provide a valid name, for your dish. Thank you.***";
                return View("BringADish");
            }
            else if (bringADish.DishDescription == null)
            {
                ViewData["Message"] = "***Please provide a short description, for what you are bringing. Thank you.***";
                return View("BringADish");
            }
            else
            {
                return View(bringADish);
            }
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
