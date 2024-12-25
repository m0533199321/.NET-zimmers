using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;
using zimmers.core.Interfaces.IService;

namespace zimmers.service.Services
{
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _iRepository;
        public OrderService(IOrderRepository iRepository)
        {
            _iRepository = iRepository;
        }
        public IEnumerable<Order> Get()
        {
            return _iRepository.GetFull();
        }
        public Order? GetById(int id)
        {
            return _iRepository.GetById(id);
        }
        public Order Add(Order order)
        {
            return _iRepository.Add(order);
        }
        public Order Update(int id, Order order)
        {
            return _iRepository.Update(id, order);
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}
