namespace zimmers.API.PostModels
{
    public class OrderPostModel
    {
        public int UserId { get; set; }
        public int ZimmerId { get; set; }
        public DateTime Starting_date { get; set; }
        public int Num_of_nights { get; set; }
        public int Total_sum { get; set; }
    }
}
