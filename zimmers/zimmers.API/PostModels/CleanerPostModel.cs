namespace zimmers.API.PostModels
{
    public class CleanerPostModel
    {
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
        public int Total_for_an_hour_of_work { get; set; }
        public int Total_salary { get; set; }
        public int Total_working_hours { get; set; }
    }
}
