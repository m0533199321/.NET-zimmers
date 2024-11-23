using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.data.Repository
{
    public class CleanRepository: IRepository<Cleaner>
    {
        readonly DataContext _dataContext;
        public CleanRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Cleaner> Get()
        {
            return _dataContext.cleaners;
        }
        public Cleaner GetById(int id)
        {
            return _dataContext.cleaners.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Cleaner cleaners)
        {
            _dataContext.cleaners.Add(new Cleaner(cleaners));
            return _dataContext.Save(_dataContext.cleaners, "cleaner.json");
        }
        public bool Update(int id, Cleaner cleaners)
        {
            int index = _dataContext.cleaners.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.cleaners[index] = new Cleaner(id, cleaners);
                return _dataContext.Save(_dataContext.cleaners, "cleaner.json");
            }
            return false;
        }
        public bool Delete(int id)
        {

            if (_dataContext.cleaners.Remove(_dataContext.cleaners.FirstOrDefault(x => x.Id == id)))
            {
                return _dataContext.Save(_dataContext.cleaners, "cleaner.json");
            }
            return false;
        }
    }
}

