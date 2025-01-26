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
        public IEnumerable<OwnerDto> Get();
        public OwnerDto? GetById(int id);
        public OwnerDto Add(OwnerDto o);
        public OwnerDto Update(int id, OwnerDto o);
        public bool Delete(int id);
    }
}
