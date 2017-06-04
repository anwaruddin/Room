using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room.Database
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly RoomContext _context;
        public ExpenseRepository(RoomContext context)
        {
            _context = context;
        }
        public void Add(Expense expense)
        {
            _context.Add(expense);
            _context.SaveChanges();
        }

        public Expense FindExpense(int Id)
        {
            return _context.Expenses.FirstOrDefault(u => u.UserId == Id);
        }

        public IEnumerable<Expense> GetAll()
        {
            return _context.Expenses.ToList();
        }

        public void Remove(int Id)
        {
            var entity = _context.Expenses.First(k => k.UserId == Id);
            _context.Expenses.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(Expense expense)
        {
            _context.Expenses.Update(expense);
            _context.SaveChanges();
        }
    }
}
