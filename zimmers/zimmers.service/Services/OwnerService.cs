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
    public class OwnerService:IOwnerService
    {
        readonly IRepositoryManager _iManager;
        public OwnerService(IRepositoryManager repositoryManager)
        {
            _iManager = repositoryManager;
        }
        public IEnumerable<Owner> Get()
        {
            return _iManager._ownerRepository.GetFull();
        }
        public Owner? GetById(int id)
        {
            return _iManager._ownerRepository.GetById(id);
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
                owner = _iManager._ownerRepository.Add(owner);
                if(owner != null)
                    _iManager.save();
            }
            return owner;
        }
        public Owner Update(int id, Owner owner)
        {

            if (IsValidTz(owner.Tz))
            {
                owner = _iManager._ownerRepository.Update(id, owner);
                if (owner != null)
                    _iManager.save();
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
