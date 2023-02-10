using Assessment6_After_Hemory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment6_After_Hemory.Controllers
{
    public class DishController : Controller
    {
        // GET
        public IActionResult Index()
        {
            IEnumerable<string> categories = GetAllCategories();

            BringADish model = new BringADish();

            model.Categories = GetSelectListItems(categories);

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(BringADish model)
        {
            IEnumerable<string> categories = GetAllCategories();

            model.Categories = GetSelectListItems(categories);

            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmation", model);
            }

            return View("Index", model);
        }

        public ActionResult Confirmation(BringADish model)
        {
            return View(model);
        }

        private IEnumerable<string> GetAllCategories()
        {
            return new List<string>
            {
                "Appetizer",
                "Salad",
                "Main Dish",
                "Dessert",
                "Beverage"
            };
        }

        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            var selectList = new List<SelectListItem>();

            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }
    }
}
