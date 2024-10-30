using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class OrderServicies
    { 
        static List<Order> dataOrders = new List<Order>()
    {
        new Order{/*Id=5,*/User_id=5,Zimmer_id=5,
            Starting_date=new DateTime(),
            Num_of_nights=5,
            Total_sum=5555}
    };

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
            dataOrders.Add(order);
            return true;
        }
        public ActionResult<bool> Put(int id, Order order)
        {
            for (int i = 0; i < dataOrders.Count; i++)
            {
                if (id == dataOrders[i].Id)
                {
                    dataOrders[i] = new Order(order);
                    return true;
                }
            }
            return false;
        }
        public ActionResult<bool> Delete(int id)
        {
            return dataOrders.Remove(dataOrders.FirstOrDefault(x => x.Id == id));
        }

        //public OrderServicies()
        //{
        //    dataOrders = new List<Order>();
        //}
    }
}
