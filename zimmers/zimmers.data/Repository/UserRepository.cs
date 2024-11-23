using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.data.Repository
{
    public class UserRepository:IRepository<User>
    {
        readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<User> Get()
        {
            return _dataContext.users;
        }
        public User GetById(int id)
        {
            return _dataContext.users.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(User user)
        {
            _dataContext.users.Add(new User(user));
            return _dataContext.Save(_dataContext.users, "user.json");
        }
        public bool Update(int id, User user)
        {
            int index = _dataContext.users.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.users[index] = new User(id, user);
                return _dataContext.Save(_dataContext.users, "user.json");
            }
            return false;
        }
        public bool Delete(int id)
        {

            if (_dataContext.users.Remove(_dataContext.users.FirstOrDefault(x => x.Id == id)))
            {
                return _dataContext.Save(_dataContext.users, "user.json");
            }
            return false;
        }
    }
}
