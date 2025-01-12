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
        readonly IRepositoryManager _iManager;
        public OrderService(IRepositoryManager repositoryManager)
        {
            _iManager = repositoryManager;
        }
        public IEnumerable<Order> Get()
        {
            return _iManager._orderRepository.GetFull();
        }
        public Order? GetById(int id)
        {
            return _iManager._orderRepository.GetById(id);
        }
        public Order Add(Order order)
        {
            order = _iManager._orderRepository.Add(order);
            if(order != null)
                _iManager.save();
            return order;
        }
        public Order Update(int id, Order order)
        {
            order = _iManager._orderRepository.Update(id, order);
            if (order != null)
                _iManager.save();
            return order;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _iManager._orderRepository.Delete(id);
            if (isDeleted)
                _iManager.save();
            return isDeleted;
        }
    }
}
