using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zimmers.core.Entities
{
    public class Zimmer
    {
        [Key]
        public int Id { get; private set; }
        public int OwnerId { get; set; }
        public Owner owner { get; set; }
        public int CleanerId { get; set; }
        public Cleaner cleaner { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Num_of_rooms { get; set; }
        public int Num_of_beds { get; set; }
        public bool Yard_and_pool { get; set; }
        public int Total_per_night { get; set; }
        public int Num_of_nights_rented { get; set; }
        public List<Order> List_orders { get; set; }
        public Zimmer()
        {

        }
        public Zimmer(Zimmer z)
        {
            OwnerId = z.OwnerId;
            CleanerId = z.CleanerId;
            Name = z.Name;
            Address = z.Address;
            Num_of_rooms = z.Num_of_rooms;
            Num_of_beds = z.Num_of_beds;
            Yard_and_pool = z.Yard_and_pool;
            Total_per_night = z.Total_per_night;
            Num_of_nights_rented = z.Num_of_nights_rented;
        }

        //public void Copy(Zimmer my, Zimmer z)
        //{
        //    my.Owner_id = z.Owner_id != my.Owner_id ? z.Owner_id : my.Owner_id;
        //    my.Cleaner_id = z.Cleaner_id != my.Cleaner_id ? z.Cleaner_id : my.Cleaner_id;
        //    my.Name ??= z.Name;
        //    my.Address ??= z.Address;
        //    my.Num_of_rooms = z.Num_of_rooms != my.Num_of_rooms ? z.Num_of_rooms : my.Num_of_rooms;
        //    my.Num_of_beds = z.Num_of_beds != my.Num_of_beds ? z.Num_of_beds : my.Num_of_beds;
        //    my.Yard_and_pool = z.Yard_and_pool != my.Yard_and_pool ? z.Yard_and_pool : my.Yard_and_pool;
        //    my.Total_per_night = z.Total_per_night != my.Total_per_night ? z.Total_per_night : my.Total_per_night;
        //    my.Num_of_nights_rented = z.Num_of_nights_rented != my.Num_of_nights_rented ? z.Num_of_nights_rented : my.Num_of_nights_rented;
        //}
    }
}
