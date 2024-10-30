using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class ZimmerServicies
    {
        static List<Zimmer> dataZimmers = new List<Zimmer>()
    {
        new Zimmer{/*Id=3,*/Owner_id=3,Cleaner_id=3,Name="c",Address="ccc",
            Num_of_rooms=3,Num_of_beds=33,
            Yard_and_pool=true,
            Total_per_night=3333,Num_of_nights_rented=3}
    };

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
            dataZimmers.Add(zimmer);
            return true;
        }
        public ActionResult<bool> Put(int id, Zimmer zimmer)
        {
            for (int i = 0; i < dataZimmers.Count; i++)
            {
                if (id == dataZimmers[i].Id)
                {
                    dataZimmers[i] = new Zimmer(zimmer);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataZimmers.Remove(dataZimmers.FirstOrDefault(x => x.Id == id));
        }

        //public ZimmerServicies()
        //{
        //    dataZimmers = new List<Zimmer>();
        //}
    }
}
