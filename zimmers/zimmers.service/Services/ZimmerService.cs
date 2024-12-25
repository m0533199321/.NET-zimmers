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
    public class ZimmerService: IZimmerService
    {
        private readonly IZimmerRepository _iRepository;
        public ZimmerService(IZimmerRepository iRepository)
        {
            _iRepository = iRepository;
        }
        public IEnumerable<Zimmer> Get()
        {
            return _iRepository.GetFull();
        }
        public Zimmer? GetById(int id)
        {
            return _iRepository.GetById(id);
        }
        public Zimmer Add(Zimmer zimmer)
        {
            return _iRepository.Add(zimmer);
        }
        public Zimmer Update(int id, Zimmer zimmer)
        {
            return _iRepository.Update(id, zimmer);
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}
