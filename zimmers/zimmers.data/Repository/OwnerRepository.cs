using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.data.Repository
{
    public class OwnerRepository:IRepository<Owner>
    {
        readonly DataContext _dataContext;
        public OwnerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Owner> Get()
        {
            return _dataContext.owners;
        }
        public Owner GetById(int id)
        {
            return _dataContext.owners.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Owner owner)
        {
            _dataContext.owners.Add(new Owner(owner));
            return _dataContext.Save(_dataContext.owners, "owner.json");
        }
        public bool Update(int id, Owner owner)
        {
            int index = _dataContext.owners.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.owners[index] = new Owner(id, owner);
                return _dataContext.Save(_dataContext.owners, "owner.json");
            }
            return false;
        }
        public bool Delete(int id)
        {

            if (_dataContext.owners.Remove(_dataContext.owners.FirstOrDefault(x => x.Id == id)))
            {
                return _dataContext.Save(_dataContext.owners, "owner.json");
            }
            return false;
        }
    }
}
