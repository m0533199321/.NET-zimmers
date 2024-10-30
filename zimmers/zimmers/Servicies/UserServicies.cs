using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class UserServicies
    {
        //static List<User> dataUsers=new List<User>() { new User(1, 1, "a", "aaa", 11, "1a1a", new DateTime(), 111, 11, 1) };
        static List<User> dataUsers = new List<User>()
    {
        new User{/*Id=1,*/Tz=1,Name="a",Address="aaa",
            Phone=1111,Bank_account="1a",
            Date_registration=new DateTime(),
            Max_amount_per_night=11,Num_of_orders=1,
            Num_of_persons=11}
    };

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
            dataUsers.Add(user);
            return true;
        }
        public ActionResult<bool> Put(int id, User user)
        {
            for (int i = 0; i < dataUsers.Count; i++)
            {
                if (id == dataUsers[i].Id)
                {
                    dataUsers[i] = new User(user);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataUsers.Remove(dataUsers.FirstOrDefault(x => x.Id == id));
        }

        //public UserServicies()
        //{
        //    dataUsers = new List<User>();
        //}
    }
}
