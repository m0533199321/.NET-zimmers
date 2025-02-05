using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Interfaces.IRepository;

namespace zimmers.core.Interfaces
{
    public interface IRepositoryManager
    {
        ICleanerRepository _cleanerRepository { get; set; }
        IOrderRepository _orderRepository { get; set; }
        IOwnerRepository _ownerRepository { get; set; }
        IUserRepository _userRepository { get; set; }
        IZimmerRepository _zimmerRepository { get; set; }
        Task saveAsync();
    }
}
