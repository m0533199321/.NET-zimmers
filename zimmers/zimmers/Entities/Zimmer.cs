using System.Net;
using System.Xml.Linq;

namespace zimmers.Entities
{
    public class Zimmer
    {
        static int id = 1;
        public int Id { get;private set; }
        public int Owner_id { get; set; }
        public int Cleaner_id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Num_of_rooms { get; set; }
        public int Num_of_beds { get; set; }
        public bool Yard_and_pool { get; set; }
        public int Total_per_night { get; set; }
        public int Num_of_nights_rented { get; set; }
        public Zimmer()
        {
            Id = id;
            id++;
        }
        public Zimmer(Zimmer z)
        {
            Id = id;
            id++;
            Owner_id = z.Owner_id;
            Cleaner_id = z.Cleaner_id;
            Name = z.Name;
            Address = z.Address;
            Num_of_rooms = z.Num_of_rooms;
            Num_of_beds = z.Num_of_beds;
            Yard_and_pool = z.Yard_and_pool;
            Total_per_night = z.Total_per_night;
            Num_of_nights_rented = z.Num_of_nights_rented;
        }
        //public Zimmer(int id, int owner_id, int cleaner_id, string name, string address, int num_of_rooms, int num_of_beds, bool yard_and_pool, int total_per_night, int num_of_nights_rented)
        //{
        //    Id = id;
        //    Owner_id = owner_id;
        //    Cleaner_id = cleaner_id;
        //    Name = name;
        //    Address = address;
        //    Num_of_rooms = num_of_rooms;
        //    Num_of_beds = num_of_beds;
        //    Yard_and_pool = yard_and_pool;
        //    Total_per_night = total_per_night;
        //    Num_of_nights_rented = num_of_nights_rented;
        //}
    }
}
