using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;
using zimmers.core.Interfaces.IService;

namespace zimmers.service.Services
{
    public class UserService : IUserService
    {
        readonly IRepositoryManager _iManager;
        public UserService(IRepositoryManager repositoryManager)
        {
            _iManager = repositoryManager;
        }
        public IEnumerable<User> Get()
        {
            return _iManager._userRepository.GetFull();
        }
        public User? GetById(int id)
        {
            return _iManager._userRepository.GetById(id);
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
        public User Add(User user)
        {
            if (IsValidTz(user.Tz))
            {
                user = _iManager._userRepository.Add(user);
                if (user != null)
                    _iManager.save();
            }
            return user;
        }
        public User Update(int id, User user)
        {

            if (IsValidTz(user.Tz))
            {
                user = _iManager._userRepository.Update(id, user);
                if (user != null)
                    _iManager.save();
            }
            return user;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _iManager._userRepository.Delete(id);
            if (isDeleted)
                _iManager.save();
            return isDeleted;
        }
    }
}