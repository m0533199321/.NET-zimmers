using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IOwnerService
    {
        public Task<IEnumerable<OwnerDto>> GetAsync();
        public Task<OwnerDto?> GetByIdAsync(int id);
        public Task<OwnerDto> AddAsync(OwnerDto o);
        public Task<OwnerDto> UpdateAsync(int id, OwnerDto o);
        public Task<bool> DeleteAsync(int id);
    }
}
