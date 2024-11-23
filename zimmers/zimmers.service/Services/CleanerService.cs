using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.service.Services
{
    public class CleanerService:IService<Cleaner>
    {
        readonly IRepository<Cleaner> _iRepository;
        public CleanerService(IRepository<Cleaner> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Cleaner> Get()
        {
            return _iRepository.Get();
        }
        public Cleaner GetById(int id)
        {
            return _iRepository.GetById(id);
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
        public bool Add(Cleaner cleaner)
        {
            if (IsValidTz(cleaner.Tz))
            {
                return _iRepository.Add(cleaner);
            }
            return false;
        }
        public bool Update(int id, Cleaner cleaner)
        {

            if (IsValidTz(cleaner.Tz))
            {
                return _iRepository.Update(id, cleaner);
            }
            return false;
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}
