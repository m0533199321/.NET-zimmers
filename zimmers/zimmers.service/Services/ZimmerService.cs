using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.service.Services
{
    public class ZimmerService: IZimmerService
    {
        readonly IRepository<Zimmer> _iRepository;
        public ZimmerService(IRepository<Zimmer> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Zimmer> Get()
        {
            return _iRepository.Get();
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
