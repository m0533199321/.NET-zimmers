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
    public class OrderRepository:Repository<Order>, IOrderRepository
    {
        readonly DbSet<Order> _dbset;
        public OrderRepository(DataContext dataContext)
            : base(dataContext)
        {
            _dbset = dataContext.Set<Order>();
        }


        public async Task<IEnumerable<Order>> GetFullAsync()
        {
            return await _dbset.Include(u=> u.User).Include(z=>z.Zimmer).ToListAsync();
        }






        //public Order GetById(int id)
        //{
        //    return _dataContext.orders.FirstOrDefault(x => x.Id == id);
        //}
        //public bool Add(Order order)
        //{
        //    _dataContext.orders.Add(new Order(order));
        //    return _dataContext.Save(_dataContext.orders, "order.json");
        //}
        //public bool Update(int id, Order order)
        //{
        //    int index = _dataContext.orders.FindIndex(x => x.Id == id);
        //    if (index != -1)
        //    {
        //        _dataContext.orders[index] = new Order(id, order);
        //        return _dataContext.Save(_dataContext.orders, "order.json");
        //    }
        //    return false;
        //}
        //public bool Delete(int id)
        //{

        //    if (_dataContext.orders.Remove(_dataContext.orders.FirstOrDefault(x => x.Id == id)))
        //    {
        //        return _dataContext.Save(_dataContext.orders, "order.json");
        //    }
        //    return false;
        //}
    }
}
