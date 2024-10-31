using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class OrderServicies
    {
        static List<Order> dataOrders = new List<Order>();
    
        public List<Order> Get()
        {
            return dataOrders;
        }
        public Order GetById(int id)
        {
            return dataOrders.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Post(Order order)
        {
            dataOrders.Add(new Order(order));
            return true;
        }
        public ActionResult<bool> Put(int id, Order order)
        {
            for (int i = 0; i < dataOrders.Count; i++)
            {
                if (id == dataOrders[i].Id)
                {
                    dataOrders[i] = new Order(id,order);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataOrders.Remove(dataOrders.FirstOrDefault(x => x.Id == id));
        }

    }
}
