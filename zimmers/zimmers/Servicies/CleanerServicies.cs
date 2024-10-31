using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class CleanerServicies
    {
        static List<Cleaner> dataCleaners = new List<Cleaner>();

        public List<Cleaner> Get()
        {
            return dataCleaners;
        }
        public Cleaner GetById(int id)
        {
            return dataCleaners.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Cleaner cleaner)
        {
            dataCleaners.Add(new Cleaner(cleaner));
            return true;
        }
        public ActionResult<bool> Put(int id, Cleaner cleaner)
        {
            for (int i = 0; i < dataCleaners.Count; i++)
            {
                if (id == dataCleaners[i].Id)
                {
                    dataCleaners[i] = new Cleaner(id, cleaner);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataCleaners.Remove(dataCleaners.FirstOrDefault(x => x.Id == id));
        }

    }
}
