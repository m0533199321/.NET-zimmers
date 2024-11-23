using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.service.Services
{
    public class OrderService:IService<Order>
    {
        readonly IRepository<Order> _iRepository;
        public OrderService(IRepository<Order> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Order> Get()
        {
            return _iRepository.Get();
        }
        public Order GetById(int id)
        {
            return _iRepository.GetById(id);
        }
        public bool Add(Order order)
        {
            return _iRepository.Add(order);
        }
        public bool Update(int id, Order order)
        {
            return _iRepository.Update(id, order);
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}
