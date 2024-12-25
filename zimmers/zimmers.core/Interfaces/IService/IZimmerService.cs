using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IZimmerService
    {
        public IEnumerable<Zimmer> Get();
        public Zimmer? GetById(int id);
        public Zimmer Add(Zimmer z);
        public Zimmer Update(int id, Zimmer z);
        public bool Delete(int id);
    }
}
