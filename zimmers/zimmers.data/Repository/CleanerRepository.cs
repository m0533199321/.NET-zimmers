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
    public class CleanerRepository: Repository<Cleaner>, ICleanerRepository
    {
        readonly DbSet<Cleaner> _dbset;
        public CleanerRepository(DataContext dataContext, IRepositoryManager repositoryManager)
            : base(dataContext, repositoryManager)
        {
            _dbset = dataContext.Set<Cleaner>();
        }
        public IEnumerable<Cleaner> GetFull()
        {
           return _dbset.Include(z => z.List_zimmers).ToList();
        }
        //public Cleaner GetById(int id)
        //{
        //    return _dataContext.cleaners.FirstOrDefault(x => x.Id == id);
        //}
        //public bool Add(Cleaner cleaners)
        //{
        //    _dataContext.cleaners.Add(new Cleaner(cleaners));
        //    return _dataContext.Save(_dataContext.cleaners, "cleaner.json");
        //}
        //public bool Update(int id, Cleaner cleaners)
        //{
        //    int index = _dataContext.cleaners.FindIndex(x => x.Id == id);
        //    if (index != -1)
        //    {
        //        _dataContext.cleaners[index] = new Cleaner(id, cleaners);
        //        return _dataContext.Save(_dataContext.cleaners, "cleaner.json");
        //    }
        //    return false;
        //}
        //public bool Delete(int id)
        //{

        //    if (_dataContext.cleaners.Remove(_dataContext.cleaners.FirstOrDefault(x => x.Id == id)))
        //    {
        //        return _dataContext.Save(_dataContext.cleaners, "cleaner.json");
        //    }
        //    return false;
        //}
    }
}

