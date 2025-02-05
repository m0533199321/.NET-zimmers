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
        public async Task<IEnumerable<UserDto>> GetAsync()
        {
            var users = await _iManager._userRepository.GetAsync();
            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);
            return usersDto;
        }
        public async Task<UserDto?> GetByIdAsync(int id)
        {
            var user = await _iManager._userRepository.GetByIdAsync(id);
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
        public async Task<UserDto> AddAsync(UserDto userDto)
        {
            if (IsValidTz(userDto.Tz))
            {
                var user = _mapper.Map<User>(userDto);
                user = await _iManager._userRepository.AddAsync(user);
                if (user != null)
                {
                    await _iManager.saveAsync();
                    return userDto;
                }
            }
            return null;
        }
        public async Task<UserDto> UpdateAsync(int id, UserDto userDto)
        {
            if (IsValidTz(userDto.Tz))
            {
                var user = _mapper.Map<User>(userDto);
                user = await _iManager._userRepository.UpdateAsync(id, user);
                if (user != null)
                {
                    await _iManager.saveAsync();
                    userDto = _mapper.Map<UserDto>(user);
                    return userDto;
                }
            }
            return null;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            bool isDeleted = await _iManager._userRepository.DeleteAsync(id);
            if (isDeleted)
                await _iManager.saveAsync();
            return isDeleted;
        }
    }
}