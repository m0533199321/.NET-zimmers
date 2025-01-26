using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;

namespace zimmers.core.Interfaces
{
    public interface IOrderService
    {
        public IEnumerable<OrderDto> Get();
        public OrderDto? GetById(int id);
        public OrderDto Add(OrderDto o);
        public OrderDto Update(int id, OrderDto o);
        public bool Delete(int id);
    }
}
