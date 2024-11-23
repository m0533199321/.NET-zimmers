using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.data.Repository
{
    public class ZimmerRepository:IRepository<Zimmer>
    {
        readonly DataContext _dataContext;
        public ZimmerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Zimmer> Get()
        {
            return _dataContext.zimmers;
        }
        public Zimmer GetById(int id)
        {
            return _dataContext.zimmers.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Zimmer zimmer)
        {
            _dataContext.zimmers.Add(new Zimmer(zimmer));
            return _dataContext.Save(_dataContext.zimmers, "zimmer.json");
        }
        public bool Update(int id, Zimmer zimmer)
        {
            int index = _dataContext.zimmers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                _dataContext.zimmers[index] = new Zimmer(id, zimmer);
                return _dataContext.Save(_dataContext.zimmers, "zimmer.json");
            }
            return false;
        }
        public bool Delete(int id)
        {

            if (_dataContext.zimmers.Remove(_dataContext.zimmers.FirstOrDefault(x => x.Id == id)))
            {
                return _dataContext.Save(_dataContext.zimmers, "zimmer.json");
            }
            return false;
        }
    }
}
