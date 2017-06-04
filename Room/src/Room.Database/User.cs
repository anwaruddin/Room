using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room.Database
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }

        public string Mobile { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
