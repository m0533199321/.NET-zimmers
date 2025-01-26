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
        public IEnumerable<CleanerDto> Get();
        public CleanerDto? GetById(int id);
        public CleanerDto Add(CleanerDto c);
        public CleanerDto Update(int id, CleanerDto c);
        public bool Delete(int id);
    }
}
