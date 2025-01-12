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
    public class CleanerService:ICleanerService
    {
        readonly IRepositoryManager _iManager;
        public CleanerService(IRepositoryManager repositoryManager)
        {
            _iManager = repositoryManager;
        }
        public IEnumerable<Cleaner> Get()
        {
            return _iManager._cleanerRepository.GetFull();
        }
        public Cleaner? GetById(int id)
        {
            return _iManager._cleanerRepository.GetById(id);
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
        public Cleaner Add(Cleaner cleaner)
        {
            if (IsValidTz(cleaner.Tz))
            {
                cleaner = _iManager._cleanerRepository.Add(cleaner);
                if(cleaner !=null)
                    _iManager.save();
            }
            return cleaner;
        }
        public Cleaner Update(int id, Cleaner cleaner)
        {

            if (IsValidTz(cleaner.Tz))
            {
                cleaner = _iManager._cleanerRepository.Update(id, cleaner);
                if (cleaner != null)
                    _iManager.save();
            }
            return cleaner;
        }
        public bool Delete(int id)
        {
            bool isDeleted = _iManager._cleanerRepository.Delete(id);
            if(isDeleted)
                _iManager._cleanerRepository.Delete(id);
            return isDeleted;
        }
    }
}
