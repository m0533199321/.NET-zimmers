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
        public Task<IEnumerable<OrderDto>> GetAsync();
        public Task<OrderDto?> GetByIdAsync(int id);
        public Task<OrderDto> AddAsync(OrderDto o);
        public Task<OrderDto> UpdateAsync(int id, OrderDto o);
        public Task<bool> DeleteAsync(int id);
    }
}
