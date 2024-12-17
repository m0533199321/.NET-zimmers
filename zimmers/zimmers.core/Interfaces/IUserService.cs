using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IUserService
    {
        public List<User> Get();
        public User? GetById(int id);
        public User Add(User u);
        public User Update(int id, User u);
        public bool Delete(int id);
    }
}
