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
        public Order(int id_from_body,Order o)
        {
            Id = id_from_body;
            User_id = o.User_id;
            Zimmer_id = o.Zimmer_id;
            Starting_date = o.Starting_date;
            Num_of_nights = o.Num_of_nights;
            Total_sum = o.Total_sum;
        }
    }
}
