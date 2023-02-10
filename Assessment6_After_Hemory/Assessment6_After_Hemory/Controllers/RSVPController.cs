using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assessment6_After_Hemory.Models;

namespace Assessment6_After_Hemory.Controllers
{
    public class RSVPController : Controller
    {
        // GET
        public IActionResult Index()
        {
            IEnumerable<string> dates = GetAllDates();

            TeamMember model = new TeamMember();

            model.Dates = GetSelectListItems(dates);

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TeamMember model)
        {
            IEnumerable<string> dates = GetAllDates();

            model.Dates = GetSelectListItems(dates);

            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmation", model);
            }

            return View("Index", model);
        }

        public ActionResult Confirmation(TeamMember model)
        {
            return View(model);
        }

        private IEnumerable<string> GetAllDates()
        {
            return new List<string>
            {
                "12/23/21",
                "12/24/21",
                "12/25/21"
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
