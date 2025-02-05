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
    public class ZimmerRepository:Repository<Zimmer>, IZimmerRepository
    {
        private readonly DbSet<Zimmer> _dbset;
        public ZimmerRepository(DataContext dataContext)
            :base(dataContext)
        {
            _dbset = dataContext.Set<Zimmer>();
        }
        public async Task<IEnumerable<Zimmer>> GetFullAsync()
        {
            return await _dbset.Include(c=>c.cleaner).Include(o=>o.owner).Include(o=>o.List_orders).ToListAsync();
        }





        //public Zimmer GetById(int id)
        //{
        //    return _dataContext.zimmers.FirstOrDefault(x => x.Id == id);
        //}
        //public bool Add(Zimmer zimmer)
        //{
        //    _dataContext.zimmers.Add(new Zimmer(zimmer));
        //    return _dataContext.Save(_dataContext.zimmers, "zimmer.json");
        //}
        //public bool Update(int id, Zimmer zimmer)
        //{
        //    int index = _dataContext.zimmers.FindIndex(x => x.Id == id);
        //    if (index != -1)
        //    {
        //        _dataContext.zimmers[index] = new Zimmer(id, zimmer);
        //        return _dataContext.Save(_dataContext.zimmers, "zimmer.json");
        //    }
        //    return false;
        //}
        //public bool Delete(int id)
        //{

        //    if (_dataContext.zimmers.Remove(_dataContext.zimmers.FirstOrDefault(x => x.Id == id)))
        //    {
        //        return _dataContext.Save(_dataContext.zimmers, "zimmer.json");
        //    }
        //    return false;
        //}
    }
}
