using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class ZimmerServicies
    {
        static List<Zimmer> dataZimmers = new List<Zimmer>();

        public List<Zimmer> Get()
        {
            return dataZimmers;
        }
        public Zimmer GetById(int id)
        {
            return dataZimmers.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Zimmer zimmer)
        {
            dataZimmers.Add(new Zimmer(zimmer));
            return true;
        }
        public bool Update(int id, Zimmer zimmer)
        {
            int index = DataManager.dataContext.dataZimmers.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                dataZimmers[index] = new Zimmer(id, zimmer);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return dataZimmers.Remove(dataZimmers.FirstOrDefault(x => x.Id == id));
        }

    }
}
