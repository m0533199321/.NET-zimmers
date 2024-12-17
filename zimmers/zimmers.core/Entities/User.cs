using System.ComponentModel.DataAnnotations;

namespace zimmers.core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
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

        //public void Copy(User my, User u)
        //{
        //    my.Tz ??= u.Tz;
        //    my.Name ??= u.Name;
        //    my.Address ??= u.Address;
        //    my.Phone ??= u.Phone;
        //    my.Bank_account ??= u.Bank_account;
        //    if(my.Date_registration !=u.Date_registration)
        //        my.Date_registration = u.Date_registration;
        //    if(my.Max_amount_per_night !=u.Max_amount_per_night)
        //        my.Max_amount_per_night =u.Max_amount_per_night;
        //    if(my.Num_of_persons !=u.Num_of_persons)
        //        my.Num_of_persons =u.Num_of_persons;
        //    if(my.Num_of_orders !=u.Num_of_orders)
        //        my.Num_of_orders =u.Num_of_orders;
        //}
    }
}