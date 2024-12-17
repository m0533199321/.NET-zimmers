using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IOrderService
    {
        public List<Order> Get();
        public Order? GetById(int id);
        public Order Add(Order o);
        public Order Update(int id, Order o);
        public bool Delete(int id);
    }
}
