using System.Net;
using System.Numerics;
using System.Xml.Linq;

namespace zimmers.Entities
{
    public class Cleaner
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
        public int Total_for_an_hour_of_work { get; set; }
        public int Total_salary { get; set; }
        public int Total_working_hours { get; set; }
        public Cleaner()
        {
            Id = id;
            id++;
        }
        public Cleaner(Cleaner c)
        {
            Id = id;
            id++;
            Tz = c.Tz;
            Name = c.Name;
            Address = c.Address;
            Phone = c.Phone;
            Bank_account = c.Bank_account;
            Date_registration = c.Date_registration;
            Total_for_an_hour_of_work = c.Total_for_an_hour_of_work;
            Total_salary = c.Total_salary;
            Total_working_hours = c.Total_working_hours;
        }
        //public Cleaner(int id, int tz, string name, string address, int phone, string bank_account, DateTime date_registration, int total_for_an_hour_of_work, int total_salary, int total_working_hours)
        //{
        //    Id = id;
        //    Tz = tz;
        //    Name = name;
        //    Address = address;
        //    Phone = phone;
        //    Bank_account = bank_account;
        //    Date_registration = date_registration;
        //    Total_for_an_hour_of_work = total_for_an_hour_of_work;
        //    Total_salary = total_salary;
        //    Total_working_hours = total_working_hours;
        //}
    }
}
