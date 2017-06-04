using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room.Database
{
    public interface IExpenseRepository
    {

        void Add(Expense expense);
        IEnumerable<Expense> GetAll();
        Expense FindExpense(int Id);
        void Remove(int Id);
        void Update(Expense expense);
    }
}
