using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IOwnerService
    {
        public List<Owner> Get();
        public Owner? GetById(int id);
        public Owner Add(Owner o);
        public Owner Update(int id, Owner o);
        public bool Delete(int id);
    }
}
