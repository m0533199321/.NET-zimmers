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
    public class OwnerService:IOwnerService
    {
        private readonly IRepositoryManager _iManager;
        private readonly IMapper _mapper;
        public OwnerService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _iManager = repositoryManager;
            _mapper = mapper;
        }
        public IEnumerable<OwnerDto> Get()
        {
            var owners = _iManager._ownerRepository.Get();
            var ownersDto = _mapper.Map<IEnumerable<OwnerDto>>(owners);
            return ownersDto;
        }
        public OwnerDto? GetById(int id)
        {
            var owner = _iManager._ownerRepository.GetById(id);
            var ownerDto = _mapper.Map<OwnerDto>(owner);
            return ownerDto;
        }
        public bool IsValidTz(string tz)
        {
            if (tz.Length != 9)
                return false;
            int sum = 0, i = 0, plus;
            while (i < tz.Length - 1)
            {
                if (tz[i] < '0' || tz[i] > '9')
                    return false;
                plus = tz[i] - '0';
                if (i % 2 == 1)
                    plus *= 2;
                if (plus > 9)
                    plus = plus / 10 + plus % 10;
                sum += plus;
                i++;
            }
            sum %= 10;
            if (10 - sum == tz[tz.Length - 1] - '0')
                return true;
            return false;
        }
        public OwnerDto Add(OwnerDto ownerDto)
        {
            if (IsValidTz(ownerDto.Tz))
            {
                var owner = _mapper.Map<Owner>(ownerDto);
                owner = _iManager._ownerRepository.Add(owner);
                if (owner != null)
                {
                    _iManager.save();
                    return ownerDto;
                }
            }
            return null;
        }
        public OwnerDto Update(int id, OwnerDto ownerDto)
        {

            if (IsValidTz(ownerDto.Tz))
            {
                var owner = _mapper.Map<Owner>(ownerDto);
                owner = _iManager._ownerRepository.Update(id, owner);
                if (owner != null)
                {
                    _iManager.save();
                    ownerDto = _mapper.Map<OwnerDto>(owner);
                    return ownerDto;
                }
            }
            return null;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _iManager._ownerRepository.Delete(id);
            if (isDeleted)
                _iManager.save();
            return isDeleted;
        }
    }
}
