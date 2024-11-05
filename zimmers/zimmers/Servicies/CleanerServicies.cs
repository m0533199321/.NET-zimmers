using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class CleanerServicies
    {
        public List<Cleaner> Get()
        {
            return DataManager.dataContext.dataCleaners;
        }
        public Cleaner GetById(int id)
        {
            return DataManager.dataContext.dataCleaners.FirstOrDefault(x => x.Id == id);
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
            if (10 - sum == tz[tz.Length-1]-'0')
                return true;
            return false;
        }
        public bool Add(Cleaner cleaner)
        {
            if (IsValidTz(cleaner.Tz))
            {
                DataManager.dataContext.dataCleaners.Add(new Cleaner(cleaner));
                return true;
            }
            return false;
        }
        public bool Update(int id, Cleaner cleaner)
        {
            int index = DataManager.dataContext.dataCleaners.FindIndex(x => x.Id == id);
            if (index != -1 && IsValidTz(cleaner.Tz))
            {
                DataManager.dataContext.dataCleaners[index] = new Cleaner(id, cleaner);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return DataManager.dataContext.dataCleaners.Remove(DataManager.dataContext.dataCleaners.FirstOrDefault(x => x.Id == id));
        }

    }
}
