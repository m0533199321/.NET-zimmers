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
        public IEnumerable<ZimmerDto> Get();
        public ZimmerDto? GetById(int id);
        public ZimmerDto Add(ZimmerDto z);
        public ZimmerDto Update(int id, ZimmerDto z);
        public bool Delete(int id);
    }
}
