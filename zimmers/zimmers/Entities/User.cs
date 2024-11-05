namespace zimmers.Entities
{
    public class User
    {
        static int id = 1;
        public int Id { get; private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Bank_account { get; set; }
        //public DateOnly Date_registration { get; set; }

        public DateTime Date_registration { get; set; }
        public int Max_amount_per_night { get; set; }
        public int Num_of_persons { get; set; }
        public int Num_of_orders { get; set; }
        public User()
        {
            
        }
        public User(User u)
        {
            Id = id;
            id++;
            this.Tz = u.Tz;
            this.Name = u.Name;
            this.Address = u.Address;
            this.Phone = u.Phone;
            this.Bank_account = u.Bank_account;
            this.Date_registration = u.Date_registration;
            this.Max_amount_per_night = u.Max_amount_per_night;
            this.Num_of_persons = u.Num_of_persons;
            this.Num_of_orders = u.Num_of_orders;
        }
        public User(int id_from_body,User u)
        {
            Id = id_from_body;
            this.Tz = u.Tz;
            this.Name = u.Name;
            this.Address = u.Address;
            this.Phone = u.Phone;
            this.Bank_account = u.Bank_account;
            this.Date_registration = u.Date_registration;
            this.Max_amount_per_night = u.Max_amount_per_night;
            this.Num_of_persons = u.Num_of_persons;
            this.Num_of_orders = u.Num_of_orders;
        }
    }
}
