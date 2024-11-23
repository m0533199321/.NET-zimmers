using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.service.Services
{
    public class UserService:IService<User>
    {
        readonly IRepository<User> _iRepository;
        public UserService(IRepository<User> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<User> Get()
        {
            return _iRepository.Get();
        }
        public User GetById(int id)
        {
           return _iRepository.GetById(id);
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
                return _iRepository.Add(user);
            }
            return false;
        }
        public bool Update(int id, User user)
        {
            
            if (IsValidTz(user.Tz))
            {
                return _iRepository.Update(id, user);
            }
            return false;
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}