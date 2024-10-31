using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class OwnerServicies
    {
        static List<Owner> dataOwners = new List<Owner>();
       
        public List<Owner> Get()
        {
            return dataOwners;
        }
        public Owner GetById(int id)
        {
            return dataOwners.FirstOrDefault(x => x.Id == id);
            //for (int i = 0; i < dataOwners.Count; i++)
            //{
            //    if (id == dataOwners[i].Id)
            //    {
            //        return dataOwners[i];
            //    }
            //}
            //return null;

        }
        public ActionResult<bool> Post(Owner owner)
        {
            dataOwners.Add(new Owner(owner));
            return true;
        }
        public ActionResult<bool> Put(int id, Owner owner)
        {
            for (int i = 0; i < dataOwners.Count; i++)
            {
                if (id == dataOwners[i].Id)
                {
                    dataOwners[i] = new Owner(id,owner);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataOwners.Remove(dataOwners.FirstOrDefault(x => x.Id == id));
        }

    }
}
