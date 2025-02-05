using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces.IService
{
    public interface ICleanerService
    {
        public Task<IEnumerable<CleanerDto>> GetAsync();
        public Task<CleanerDto?> GetByIdAsync(int id);
        public Task<CleanerDto> AddAsync(CleanerDto c);
        public Task<CleanerDto> UpdateAsync(int id, CleanerDto c);
        public Task<bool> DeleteAsync(int id);
    }
}
