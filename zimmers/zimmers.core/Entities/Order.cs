using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Interfaces;

namespace zimmers.core.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; private set; }
        public int User_id { get; set; }
        public int Zimmer_id { get; set; }
        public DateTime Starting_date { get; set; }
        public int Num_of_nights { get; set; }
        public int Total_sum { get; set; }
        public Order()
        {

        }
        public Order(Order o)
        { 
            User_id = o.User_id;
            Zimmer_id = o.Zimmer_id;
            Starting_date = o.Starting_date;
            Num_of_nights = o.Num_of_nights;
            Total_sum = o.Total_sum;
        }

        //public void Copy(Order my, Order o)
        //{
        //    my.User_id = o.User_id != my.User_id ? o.User_id : my.User_id;
        //    my.Zimmer_id = o.Zimmer_id != my.Zimmer_id ? o.Zimmer_id : my.Zimmer_id;
        //    if(my.Starting_date !=o.Starting_date)
        //        my.Starting_date = o.Starting_date;
        //    my.Num_of_nights = o.Num_of_nights != my.Num_of_nights ? o.Num_of_nights : my.Num_of_nights;
        //    my.Total_sum = o.Total_sum != my.Total_sum ? o.Total_sum : my.Total_sum;
        //}
    }
}
