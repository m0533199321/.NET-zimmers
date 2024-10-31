using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class UserServicies
    {

        static List<User> dataUsers = new List<User>();
        public List<User> Get()
        {
            return dataUsers;
        }
        public User GetById(int id)
        {
            return dataUsers.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(User user)
        {
            dataUsers.Add(new User(user));
            return true;
        }
        public ActionResult<bool> Put(int id, User user)
        {
            for (int i = 0; i < dataUsers.Count; i++)
            {
                if (id == dataUsers[i].Id)
                {
                    dataUsers[i] = new User(id, user);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataUsers.Remove(dataUsers.FirstOrDefault(x => x.Id == id));
        }
    }
}
