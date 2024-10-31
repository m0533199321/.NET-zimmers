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
        public Owner(int id_from_body,Owner o)
        {
            Id = id_from_body; 
            Tz = o.Tz;
            Name = o.Name;
            Address = o.Address;
            Phone = o.Phone;
            Bank_account = o.Bank_account;
            Date_registration = o.Date_registration;
        }
    }
}
