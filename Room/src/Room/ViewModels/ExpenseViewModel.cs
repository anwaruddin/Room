using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Room.ViewModels
{
    public class ExpenseViewModel
    {

        public int ExpenseId { get; set; }

        public DateTime Date { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage = "Amount is Required")]
        [DisplayName("Amount")]
        public double Amount { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        [DisplayName("User Name")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Users is Required")]
        [DisplayName("User Name")]

        public string Users { get; set; }


        public List<SelectListItem> ListUsers { get; set; }
    }
}
