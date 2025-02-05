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
        public async Task<IEnumerable<OrderDto>> GetAsync()
        {
            var orders = await _iManager._orderRepository.GetAsync();
            var ordersDto = _mapper.Map<IEnumerable<OrderDto>>(orders);
            return ordersDto;
        }
        public async Task<OrderDto?> GetByIdAsync(int id)
        {
            var order = await _iManager._orderRepository.GetByIdAsync(id);
            var orderDto = _mapper.Map<OrderDto>(order);
            return orderDto;
        }
        public async Task<OrderDto> AddAsync(OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            order = await _iManager._orderRepository.AddAsync(order);
            if (order != null)
            { 
                await _iManager.saveAsync();
                return orderDto;
            }
            return null;
        }
        public async Task<OrderDto> UpdateAsync(int id, OrderDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            order = await _iManager._orderRepository.UpdateAsync(id, order);
            if (order != null)
            { 
                await _iManager.saveAsync();
                orderDto = _mapper.Map<OrderDto>(order);
                return orderDto;
            }
            return null;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            bool isDeleted = await _iManager._orderRepository.DeleteAsync(id);
            if (isDeleted)
                await _iManager.saveAsync();
            return isDeleted;
        }
    }
}
