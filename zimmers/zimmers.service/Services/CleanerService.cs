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
using zimmers.data.Repository;

namespace zimmers.service.Services
{
    public class CleanerService : ICleanerService
    {
       private readonly IRepositoryManager _iManager;
       private readonly IMapper _mapper;
        public CleanerService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _iManager = repositoryManager;
            _mapper = mapper;
        }

        public IEnumerable<CleanerDto> Get()
        {
            var cleaners = _iManager._cleanerRepository.Get();
            var cleanersDto = _mapper.Map<IEnumerable<CleanerDto>>(cleaners);
            return cleanersDto;
        }

        public CleanerDto? GetById(int id)
        {
            var cleaner = _iManager._cleanerRepository.GetById(id);
            var cleanerDto = _mapper.Map<CleanerDto>(cleaner);
            return cleanerDto;
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

        public CleanerDto Add(CleanerDto cleanerDto)
        {
            if (IsValidTz(cleanerDto.Tz))
            {
                var cleaner = _mapper.Map<Cleaner>(cleanerDto);
                cleaner = _iManager._cleanerRepository.Add(cleaner);
                if (cleaner != null)
                {
                    _iManager.save();
                    return cleanerDto;
                }
            }
            return null;
        }

        public CleanerDto Update(int id, CleanerDto cleanerDto)
        {
            if (IsValidTz(cleanerDto.Tz))
            {
                var cleaner = _mapper.Map<Cleaner>(cleanerDto);
                cleaner = _iManager._cleanerRepository.Update(id, cleaner);
                if (cleaner != null)
                {
                    _iManager.save();
                    return cleanerDto;
                }
            }
            return null;
        }

        public bool Delete(int id)
        {
            bool isDeleted = _iManager._cleanerRepository.Delete(id);
            if (isDeleted)
                _iManager.save();
            return isDeleted;
        }
    }
}
