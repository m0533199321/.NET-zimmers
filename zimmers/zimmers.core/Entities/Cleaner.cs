using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Interfaces;

namespace zimmers.core.Entities
{
    public class Cleaner
    {
        [Key]
        public int Id { get; private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
        public int Total_for_an_hour_of_work { get; set; }
        public int Total_salary { get; set; }
        public int Total_working_hours { get; set; }
        public List<Zimmer> List_zimmers { get; set; }
        public Cleaner()
        {

        }
        public Cleaner(Cleaner c)
        {
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
        //public void Copy(Cleaner my, Cleaner c)
        //{
        //    my.Tz??= c.Tz;
        //    my.Name ??= c.Name;
        //    my.Address ??= c.Address;
        //    my.Phone ??= c.Phone;
        //    my.Bank_account ??= c.Bank_account;
        //    if(c.Date_registration!= my.Date_registration)
        //        my.Date_registration = c.Date_registration;
        //    if(my.Total_for_an_hour_of_work !=c.Total_for_an_hour_of_work)
        //        my.Total_for_an_hour_of_work = c.Total_for_an_hour_of_work;
        //    if (my.Total_salary != c.Total_salary)
        //        my.Total_salary = c.Total_salary;
        //    if (my.Total_working_hours != c.Total_working_hours)
        //        my.Total_working_hours = c.Total_working_hours;
        //}
    }
}
