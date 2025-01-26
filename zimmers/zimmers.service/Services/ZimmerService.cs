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
    public class ZimmerService : IZimmerService
    {
        private readonly IRepositoryManager _iManager;
        private readonly IMapper _mapper;
        public ZimmerService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _iManager = repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<ZimmerDto> Get()
        {
            var zimmers = _iManager._zimmerRepository.Get();
            var zimmersDto = _mapper.Map<IEnumerable<ZimmerDto>>(zimmers);
            return zimmersDto;
        }
        public ZimmerDto? GetById(int id)
        {
            var zimmer = _iManager._zimmerRepository.GetById(id);
            var zimmerDto = _mapper.Map<ZimmerDto>(zimmer);
            return zimmerDto;
        }
        public ZimmerDto Add(ZimmerDto zimmerDto)
        {
            var zimmer = _mapper.Map<Zimmer>(zimmerDto);
            zimmer = _iManager._zimmerRepository.Add(zimmer);
            if (zimmer != null)
            {
                _iManager.save();
                return zimmerDto;
            }
            return null;
        }
        public ZimmerDto Update(int id, ZimmerDto zimmerDto)
        {
            var zimmer = _mapper.Map<Zimmer>(zimmerDto);
            zimmer = _iManager._zimmerRepository.Update(id, zimmer);
            if (zimmer != null)
            {
                _iManager.save();
                return zimmerDto;
            }
            return null;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _iManager._zimmerRepository.Delete(id);
            if (isDeleted)
                _iManager.save();
            return isDeleted;
        }
    }
}
