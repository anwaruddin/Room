using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Room.Database
{
    public interface IUserRepository
    {
        void Add(User user);
        IEnumerable<User> GetAll();
        User FindUser(int Id);
        void Remove(int Id);
        void Update(User user);
    }
}
