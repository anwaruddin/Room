
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Room.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName is Required")]
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Role is Required")]
        [DisplayName("Role")]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Mobile is Required")]
        [DisplayName("Mobile Number")]
        public string Mobile { get; set; }
        public List<SelectListItem> Roles { get; set; }


      
    }
}
