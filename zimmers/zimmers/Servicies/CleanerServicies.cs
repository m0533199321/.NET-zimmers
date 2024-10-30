using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class CleanerServicies
    {
        static List<Cleaner> dataCleaners = new List<Cleaner>() {
                new Cleaner{/*Id=4,*/Tz=4,Name="d",Address="ddd",
                Phone=4444,Bank_account="4d4d",
                Date_registration=new DateTime(),
                Total_for_an_hour_of_work=44,Total_salary=4444,
                Total_working_hours=44} };

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
            dataCleaners.Add(cleaner);
            return true;
        }
        public ActionResult<bool> Put(int id, Cleaner cleaner)
        {
            for (int i = 0; i < dataCleaners.Count; i++)
            {
                if (id == dataCleaners[i].Id)
                {
                    dataCleaners[i] = new Cleaner(cleaner);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataCleaners.Remove(dataCleaners.FirstOrDefault(x => x.Id == id));
        }

        //public CleanerServicies()
        //{
        //    dataCleaners = new List<Cleaner>();
        //}
    }
}
