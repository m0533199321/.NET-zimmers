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
        public async Task<IEnumerable<ZimmerDto>> GetAsync()
        {
            var zimmers = await _iManager._zimmerRepository.GetAsync();
            var zimmersDto = _mapper.Map<IEnumerable<ZimmerDto>>(zimmers);
            return zimmersDto;
        }
        public async Task<ZimmerDto?> GetByIdAsync(int id)
        {
            var zimmer = await _iManager._zimmerRepository.GetByIdAsync(id);
            var zimmerDto = _mapper.Map<ZimmerDto>(zimmer);
            return zimmerDto;
        }
        public async Task<ZimmerDto> AddAsync(ZimmerDto zimmerDto)
        {
            var zimmer = _mapper.Map<Zimmer>(zimmerDto);
            zimmer = await _iManager._zimmerRepository.AddAsync(zimmer);
            if (zimmer != null)
            {
                await _iManager.saveAsync();
                return zimmerDto;
            }
            return null;
        }
        public async Task<ZimmerDto> UpdateAsync(int id, ZimmerDto zimmerDto)
        {
            var zimmer = _mapper.Map<Zimmer>(zimmerDto);
            zimmer = await _iManager._zimmerRepository.UpdateAsync(id, zimmer);
            if (zimmer != null)
            {
                await _iManager.saveAsync();
                zimmerDto = _mapper.Map<ZimmerDto>(zimmer);
                return zimmerDto;
            }
            return null;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            bool isDeleted = await _iManager._zimmerRepository.DeleteAsync(id);
            if (isDeleted)
                await _iManager.saveAsync();
            return isDeleted;
        }
    }
}
