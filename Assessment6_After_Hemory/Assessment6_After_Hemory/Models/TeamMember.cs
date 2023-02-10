using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assessment6_After_Hemory.Models
{
    public class TeamMember
    {
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Must have at least 1 character")]
        [MinLength(1)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }

        public string DateAttending { get; set; }

        public IEnumerable<SelectListItem> Dates { get; set; }
        public string GuestName { get; set; }
    }
}
