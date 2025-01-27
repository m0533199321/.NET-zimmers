using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.DTOs;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;
using zimmers.core.Interfaces.IService;

namespace zimmers.service.Services
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryManager _iManager;
        private readonly IMapper _mapper;
        public OrderService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _iManager = repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<OrderDto> Get()
        {
            var orders = _iManager._orderRepository.Get();
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            return ordersDto;
        }
        public OrderDto? GetById(int id)
        {
            var order = _iManager._orderRepository.GetById(id);
            var orderDto = _mapper.Map<OrderDto>(order);
            return orderDto;
        }
        public OrderDto Add(OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            order = _iManager._orderRepository.Add(order);
            if (order != null)
            { 
                _iManager.save();
                return orderDto;
            }
            return null;
        }
        public OrderDto Update(int id, OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            order = _iManager._orderRepository.Update(id, order);
            if (order != null)
            { 
                _iManager.save();
                orderDto = _mapper.Map<OrderDto>(order);
                return orderDto;
            }
            return null;
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
