using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

namespace zimmers.service.Services
{
    public class OwnerService:IOwnerService
    {
        readonly IRepository<Owner> _iRepository;
        public OwnerService(IRepository<Owner> iRepository)
        {
            _iRepository = iRepository;
        }
        public List<Owner> Get()
        {
            return _iRepository.Get();
        }
        public Owner? GetById(int id)
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
        public Owner Add(Owner owner)
        {
            if (IsValidTz(owner.Tz))
            {
                return _iRepository.Add(owner);
            }
            return null;
        }
        public Owner Update(int id, Owner owner)
        {

            if (IsValidTz(owner.Tz))
            {
                return _iRepository.Update(id, owner);
            }
            return null;
        }
        public bool Delete(int id)
        {
            return _iRepository.Delete(id);
        }
    }
}
