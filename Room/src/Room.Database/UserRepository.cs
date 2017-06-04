using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly RoomContext _context; 
        public UserRepository(RoomContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

        public User FindUser(int Id)
        {
            return _context.Users.FirstOrDefault(u => u.UserId == Id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Remove(int Id)
        {
            var entity = _context.Users.First(k => k.UserId == Id);
            _context.Users.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
