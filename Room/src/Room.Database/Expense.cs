using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room.Database
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public int UserId { get; set; }
        public double Amount { get; set; }

        public string Description { get; set; }

        public string Users { get; set; }

        public User User { get; set; }
    }
}
