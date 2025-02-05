using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces.IRepository
{
    public interface IUserRepository: IRepository<User>
    {
        public Task<IEnumerable<User>> GetFullAsync();
    }
}
