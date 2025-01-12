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
    public class ZimmerService : IZimmerService
    {
        readonly IRepositoryManager _iManager;
        public ZimmerService(IRepositoryManager repositoryManager)
        {
            _iManager = repositoryManager;
        }
        public IEnumerable<Zimmer> Get()
        {
            return _iManager._zimmerRepository.GetFull();
        }
        public Zimmer? GetById(int id)
        {
            return _iManager._zimmerRepository.GetById(id);
        }
        public Zimmer Add(Zimmer zimmer)
        {
            zimmer = _iManager._zimmerRepository.Add(zimmer);
            if (zimmer != null)
                _iManager.save();
            return zimmer;
        }
        public Zimmer Update(int id, Zimmer zimmer)
        {
            zimmer = _iManager._zimmerRepository.Update(id, zimmer);
            if (zimmer != null)
                _iManager.save();
            return zimmer;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _iManager._zimmerRepository.Delete(id);
            if(isDeleted)
                _iManager.save();
            return isDeleted;
        }
    }
}
