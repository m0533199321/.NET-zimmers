namespace zimmers.Entities
{
    public class Owner
    {
        static int id = 1;
        public int Id { get; private set; }
        public int Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Bank_account { get; set; }
        //public DateOnly Date_registration { get; set; }

        public DateTime Date_registration { get; set; }
        
        public Owner()
        {
            Id = id;
            id++;
        }
        public Owner(Owner o)
        {
            Id = id;
            id++;
            Tz = o.Tz;
            Name = o.Name;
            Address = o.Address;
            Phone = o.Phone;
            Bank_account = o.Bank_account;
            Date_registration = o.Date_registration;
        }
        //public Owner(int id, int tz, string name, string address, int phone, string bank_account, DateTime date_registration)
        //{
        //    Id = id;
        //    Tz = tz;
        //    Name = name;
        //    Address = address;
        //    Phone = phone;
        //    Bank_account = bank_account;
        //    Date_registration = date_registration;
        //}
    }
}
