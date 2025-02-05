using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces.IRepository
{
    public interface ICleanerRepository: IRepository<Cleaner>
    {
        public Task<IEnumerable<Cleaner>> GetFullAsync();
    }
}
