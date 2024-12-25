using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;

namespace zimmers.data.Repository
{
    public class OwnerRepository:Repository<Owner>, IOwnerRepository
    {
        readonly DbSet<Owner> _dbset;
        public OwnerRepository(DataContext dataContext, IRepositoryManager repositoryManager)
            : base(dataContext, repositoryManager)
        {
            _dbset = dataContext.Set<Owner>();
        }


        public IEnumerable<Owner> GetFull()
        {
            return _dbset.Include(z=>z.List_zimmers).ToList();
        }


        //public Owner GetById(int id)
        //{
        //    return _dataContext.owners.FirstOrDefault(x => x.Id == id);
        //}
        //public bool Add(Owner owner)
        //{
        //    _dataContext.owners.Add(new Owner(owner));
        //    return _dataContext.Save(_dataContext.owners, "owner.json");
        //}
        //public bool Update(int id, Owner owner)
        //{
        //    int index = _dataContext.owners.FindIndex(x => x.Id == id);
        //    if (index != -1)
        //    {
        //        _dataContext.owners[index] = new Owner(id, owner);
        //        return _dataContext.Save(_dataContext.owners, "owner.json");
        //    }
        //    return false;
        //}
        //public bool Delete(int id)
        //{

        //    if (_dataContext.owners.Remove(_dataContext.owners.FirstOrDefault(x => x.Id == id)))
        //    {
        //        return _dataContext.Save(_dataContext.owners, "owner.json");
        //    }
        //    return false;
        //}
    }
}
