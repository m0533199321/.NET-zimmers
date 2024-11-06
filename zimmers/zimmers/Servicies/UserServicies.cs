using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class UserServicies
    {
        public List<User> Get()
        {
            DateTime dateTime = DateTime.Now;
            User u = new User("123", "as", "l", "1", "q", dateTime, 12, 1, 12);
            List<User> lu = new List<User>();
            lu.Add(u);
            return lu;
            //return DataManager.dataContext.dataUsers;
        }
        public User GetById(int id)
        {
            return DataManager.dataContext.dataUsers.FirstOrDefault(x => x.Id == id);
        }
        public bool IsValidTz(string tz)
        {
            if (tz.Length != 9)
                return false;
            int sum = 0, i = 0, plus;
            while (i < tz.Length - 1)
            {
                if (tz[i] < '0' || tz[i] > '9')
                    return false;
                plus = tz[i] - '0';
                if (i % 2 == 1)
                    plus *= 2;
                if (plus > 9)
                    plus = plus / 10 + plus % 10;
                sum += plus;
                i++;
            }
            sum %= 10;
            if (10 - sum == tz[tz.Length - 1] - '0')
                return true;
            return false;
        }
        public bool Add(User user)
        {
            if (IsValidTz(user.Tz))
            {
                DataManager.dataContext.dataUsers.Add(new User(user));
                return true;
            }
            return false;
        }
        public bool Update(int id, User user)
        {
            int index = DataManager.dataContext.dataUsers.FindIndex(x => x.Id == id);
            if (index != -1 && IsValidTz(user.Tz))
            {
                DataManager.dataContext.dataUsers[index] = new User(id, user);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return DataManager.dataContext.dataUsers.Remove(DataManager.dataContext.dataUsers.FirstOrDefault(x => x.Id == id));
        }
    }
}
