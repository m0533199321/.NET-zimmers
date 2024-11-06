using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class OwnerServicies
    {
        public List<Owner> Get()
        {
            return DataManager.dataContext.dataOwner;
        }
        public Owner GetById(int id)
        {
            return DataManager.dataContext.dataOwner.FirstOrDefault(x => x.Id == id);
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
            if (10 - sum == tz[tz.Length - 1]-'0')
                return true;
            return false;
        }
        public bool Add(Owner owner)
        {
            if (IsValidTz(owner.Tz))
            {
                DataManager.dataContext.dataOwner.Add(new Owner(owner));
                return true;
            }
            return false;
        }
        public bool Update(int id, Owner owner)
        {
            int index = DataManager.dataContext.dataOwner.FindIndex(x => x.Id == id);
            if (index!=-1 && IsValidTz(owner.Tz))
            {
                DataManager.dataContext.dataOwner[index] = new Owner(id, owner);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return DataManager.dataContext.dataOwner.Remove(DataManager.dataContext.dataOwner.FirstOrDefault(x => x.Id == id));
        }

    }
}
