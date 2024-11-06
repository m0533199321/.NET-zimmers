using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class ZimmerServicies
    {
        public List<Zimmer> Get()
        {
            return DataManager.dataContext.dataZimmers;
        }
        public Zimmer GetById(int id)
        {
            return DataManager.dataContext.dataZimmers.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Zimmer zimmer)
        {
            DataManager.dataContext.dataZimmers.Add(new Zimmer(zimmer));
            return true;
        }
        public bool Update(int id, Zimmer zimmer)
        {
            int index = DataManager.dataContext.dataZimmers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                DataManager.dataContext.dataZimmers[index] = new Zimmer(id, zimmer);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return DataManager.dataContext.dataZimmers.Remove(DataManager.dataContext.dataZimmers.FirstOrDefault(x => x.Id == id));
        }

    }
}
