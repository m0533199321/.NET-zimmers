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
        public IEnumerable<UserDto> Get();
        public UserDto? GetById(int id);
        public UserDto Add(UserDto u);
        public UserDto Update(int id, UserDto u);
        public bool Delete(int id);
    }
}
