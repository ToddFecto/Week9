using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment6_After_Hemory.Models
{
    public class BringADish
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Must have at least 2 characters")]
        [MinLength(2)]
        public string DishName { get; set; }

        public string DishDescription { get; set; }

        public string Category { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}
