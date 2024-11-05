using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;

namespace zimmers.Servicies
{
    public class OrderServicies
    {
        public List<Order> Get()
        {
            return DataManager.dataContext.dataOrders;
        }
        public Order GetById(int id)
        {
            return DataManager.dataContext.dataOrders.FirstOrDefault(x => x.Id == id);
        }
        public bool Add(Order order)
        {
            DataManager.dataContext.dataOrders.Add(new Order(order));
            return true;
        }
        public bool Update(int id, Order order)
        {
            int index = DataManager.dataContext.dataOrders.FindIndex(x => x.Id == id);
            if (index != -1) 
            {
                DataManager.dataContext.dataOrders[index] = new Order(id, order);
                return true;
            }
            return false;
        }
        public bool Delete(int id)
        {
            return DataManager.dataContext.dataOrders.Remove(DataManager.dataContext.dataOrders.FirstOrDefault(x => x.Id == id));
        }

    }
}
