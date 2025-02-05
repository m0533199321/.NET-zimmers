using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IUserService
    {
        public Task<IEnumerable<UserDto>> GetAsync();
        public Task<UserDto?> GetByIdAsync(int id);
        public Task<UserDto> AddAsync(UserDto u);
        public Task<UserDto> UpdateAsync(int id, UserDto u);
        public Task<bool> DeleteAsync(int id);
    }
}
