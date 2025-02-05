using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IZimmerService
    {
        public Task<IEnumerable<ZimmerDto>> GetAsync();
        public Task<ZimmerDto?> GetByIdAsync(int id);
        public Task<ZimmerDto> AddAsync(ZimmerDto z);
        public Task<ZimmerDto> UpdateAsync(int id, ZimmerDto z);
        public Task<bool> DeleteAsync(int id);
    }
}
