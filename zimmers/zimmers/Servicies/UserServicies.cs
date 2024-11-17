using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class UserServicies
    {
        private readonly IDataContext _iData;
        public UserServicies(IDataContext iData) 
        {
            _iData=iData;
        }
        public List<User> Get()
        {
            User.id = 1;
            _iData.Load();
            //DateTime dateTime = DateTime.Now;
            //User u = new User("000000026", "as", "l", "1", "q", dateTime, 12, 1, 12);
            //_iData.jsonUsers.Add(u);
            return _iData.jsonUsers;
        }
        public User GetById(int id)
        {
            User.id = 1;
            _iData.Load();
            return _iData.jsonUsers.FirstOrDefault(x => x.Id == id);
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
                User.id = 1;
                _iData.Load();
                _iData.jsonUsers.Add(new User(user));
                return _iData.Save();
            }
            return false;
        }
        public bool Update(int id, User user)
        {
            User.id = 1;
            _iData.Load();
            //DateTime dateTime = DateTime.Now;
            //User u = new User("000000026", "asd", "k", "098", "kj", dateTime, 890, 8, 9);
            //_iData.jsonUsers.Add(u);
            int index = _iData.jsonUsers.FindIndex(x => x.Id == id);
            if (index != -1 && IsValidTz(user.Tz))
            {
                _iData.jsonUsers[index] = new User(id, user);
                return _iData.Save();
            }
            return false;
        }
        public bool Delete(int id)
        {
            User.id = 1;
            _iData.Load();
            if(_iData.jsonUsers.Remove(_iData.jsonUsers.FirstOrDefault(x => x.Id == id)))
            {
                return _iData.Save();
            }
            return false;
        }
    }
}
