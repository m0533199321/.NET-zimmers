using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IRepository;

namespace zimmers.data.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        DataContext _dataContext;
        public ICleanerRepository _cleanerRepository { get; set; }
        public IOrderRepository _orderRepository { get; set; }
        public IOwnerRepository _ownerRepository { get; set; }
        public IUserRepository _userRepository { get; set; }
        public IZimmerRepository _zimmerRepository { get; set; }

        public RepositoryManager(DataContext dataContext, 
                                 ICleanerRepository cleanerRepository,
                                 IOrderRepository orderRepository,
                                 IOwnerRepository ownerRepository,
                                 IUserRepository userRepository,
                                 IZimmerRepository zimmerRepository)
        {
            _dataContext = dataContext;
            _cleanerRepository = cleanerRepository;
            _orderRepository = orderRepository;
            _ownerRepository = ownerRepository;
            _userRepository = userRepository;
            _zimmerRepository = zimmerRepository;
        }
        public async Task saveAsync()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
    //public class RepositoryManager : IRepositoryManager
    //{
    //    DataContext _dataContext;
    //    ICleanerRepository _cleanerRepository { get; set; }
    //    IOrderRepository _orderRepository { get; set; }
    //    IOwnerRepository _ownerRepository { get; set; }
    //    IUserRepository _userRepository { get; set; }
    //    IZimmerRepository _zimmerRepository { get; set; }

    //    public RepositoryManager(DataContext dataContext,
    //                ICleanerRepository cleanerRepository,
    //                    IOrderRepository orderRepository,
    //                    IOwnerRepository ownerRepository,
    //                      IUserRepository userRepository,
    //                  IZimmerRepository zimmerRepository)
    //    {
    //        _dataContext = dataContext;
    //        _cleanerRepository = cleanerRepository;
    //        _orderRepository = orderRepository;
    //        _ownerRepository = ownerRepository;
    //        _userRepository = userRepository;
    //        _zimmerRepository = zimmerRepository;
    //    }
    //    public void save()
    //    {
    //        _dataContext.SaveChanges();
    //    }
    //}
}
