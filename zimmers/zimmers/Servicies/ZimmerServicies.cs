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
        public ActionResult<bool> Post(Zimmer zimmer)
        {
            dataZimmers.Add(new Zimmer(zimmer));
            return true;
        }
        public ActionResult<bool> Put(int id, Zimmer zimmer)
        {
            for (int i = 0; i < dataZimmers.Count; i++)
            {
                if (id == dataZimmers[i].Id)
                {
                    dataZimmers[i] = new Zimmer(id,zimmer);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataZimmers.Remove(dataZimmers.FirstOrDefault(x => x.Id == id));
        }

    }
}
