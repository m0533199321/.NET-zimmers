using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace zimmers.core.Interfaces
{
    public interface IRepository<T>
    {
        public IEnumerable<T> Get();
        public T? GetById(int id);
        public T Add(T t);
        public T Update(int id, T t);
        public bool Delete(int id);
    }
}
