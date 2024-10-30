namespace zimmers.Entities
{
    public class Order
    {
        static int id = 1;
        public int Id { get;private set; }
        public int User_id { get; set; }
        public int Zimmer_id { get; set; }
        public DateTime Starting_date { get; set; }
        public int Num_of_nights { get; set; }
        public int Total_sum { get; set; }
        public Order()
        {
            Id = id;
            id++;
        }
        public Order(Order o)
        {
            Id = id;
            id++;
            User_id = o.User_id;
            Zimmer_id = o.Zimmer_id;
            Starting_date = o.Starting_date;
            Num_of_nights = o.Num_of_nights;
            Total_sum = o.Total_sum;
        }
        //public Order(int id, int user_id, int zimmer_id, DateTime starting_date, int num_of_nights, int total_sum)
        //{
        //    Id = id;
        //    User_id = user_id;
        //    Zimmer_id = zimmer_id;
        //    Starting_date = starting_date;
        //    Num_of_nights = num_of_nights;
        //    Total_sum = total_sum;
        //}
    }
}
