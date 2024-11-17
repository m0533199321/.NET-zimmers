using System;
using zimmers.Entities;

namespace zimmers
{
    public class DataContext
    {
        public List<Cleaner> dataCleaners = new List<Cleaner>();
        public List<Order> dataOrders = new List<Order>();
        public List<Owner> dataOwner = new List<Owner>();
        public List<User> dataUsers = new List<User>();
        public List<Zimmer> dataZimmers = new List<Zimmer>();
    }
}


