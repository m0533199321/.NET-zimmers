using AutoMapper;
using zimmers.core.DTOs;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;
using zimmers.core.Interfaces.IService;

namespace zimmers.service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _iManager;
        private readonly IMapper _mapper;
        public UserService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _iManager = repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<UserDto> Get()
        {
            var users = _iManager._userRepository.Get();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return usersDto;
        }
        public UserDto? GetById(int id)
        {
            var user = _iManager._userRepository.GetById(id);
            var usersDto = _mapper.Map<UserDto>(user);
            return usersDto;
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
        public UserDto Add(UserDto userDto)
        {
            if (IsValidTz(userDto.Tz))
            {
                var user = _mapper.Map<User>(userDto);
                user = _iManager._userRepository.Add(user);
                if (user != null)
                {
                    _iManager.save();
                    return userDto;
                }
            }
            return null;
        }
        public UserDto Update(int id, UserDto userDto)
        {
            if (IsValidTz(userDto.Tz))
            {
                var user = _mapper.Map<User>(userDto);
                user = _iManager._userRepository.Update(id, user);
                if (user != null)
                {
                    _iManager.save();
                    return userDto;
                }
            }
            return null;
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