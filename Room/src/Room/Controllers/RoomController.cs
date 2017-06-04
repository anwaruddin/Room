using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Room.Database;
using Room.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Room.Controllers
{
    public class RoomController : Controller
    {
        private readonly RoomContext _context;
        public RoomController(RoomContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult AddUser(int id)
        {
            UserViewModel obj;
            if (id > 0)
            {
                User objuser = _context.Users.Where(m => m.UserId == id).SingleOrDefault();
                if (objuser != null)
                {
                    obj = new UserViewModel { UserId = objuser.UserId, UserName = objuser.UserName, Email = objuser.Email, Mobile = objuser.Mobile, RoleId = objuser.RoleId };
                    obj.Roles = _context.Roles.Select(o => new SelectListItem { Value = o.RoleId.ToString(), Text = o.RoleName }).ToList();
                   
                    return View(obj);

                }
              

            }
            obj = new UserViewModel();
            obj.Roles = _context.Roles.Select(o => new SelectListItem { Value = o.RoleId.ToString(), Text = o.RoleName }).ToList();
            return View(obj);
        }


        [HttpPost]
        public IActionResult AddUser(UserViewModel user)
        {
            if(ModelState.IsValid)
            {
                Room.Database.User objnewUser = new Database.User { UserName = user.UserName, Email = user.Email, Mobile = user.Mobile, RoleId = user.RoleId };
                _context.Users.Add(objnewUser);
                _context.SaveChanges();
            }

            UserViewModel obj;
            obj = new UserViewModel();
            obj.Roles = _context.Roles.Select(o => new SelectListItem { Value = o.RoleId.ToString(), Text = o.RoleName }).ToList();
            return View(obj);
        }



        public IActionResult AddExpense(int id)
        {
            ExpenseViewModel obj;
            if (id > 0)
            {
                Expense objuser = _context.Expenses.Where(m => m.ExpenseId == id).SingleOrDefault();
                if (objuser != null)
                {
                    obj = new ExpenseViewModel { ExpenseId= objuser.ExpenseId, UserId = objuser.UserId, Description = objuser.Description, Users = objuser.Users };
                    obj.ListUsers = _context.Users.Select(o => new SelectListItem { Value = o.UserId.ToString(), Text = o.UserName }).ToList();

                    return View(obj);

                }


            }
            obj = new ExpenseViewModel();
            obj.ListUsers = _context.Users.Select(o => new SelectListItem { Value = o.UserId.ToString(), Text = o.UserName }).ToList();
            return View(obj);
        }
        }


}
