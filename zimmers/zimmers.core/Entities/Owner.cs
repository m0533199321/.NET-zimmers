using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zimmers.core.Entities
{
    public class Owner
    {
        [Key]
        public int Id { get; private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
        public List<Zimmer> List_zimmers { get; set; }

        public Owner()
        {

        }
        public Owner(Owner o)
        {
            Tz = o.Tz;
            Name = o.Name;
            Address = o.Address;
            Phone = o.Phone;
            Bank_account = o.Bank_account;
            Date_registration = o.Date_registration;
        }

        //public void Copy(Owner my, Owner o)
        //{
        //    my.Tz ??= o.Tz;
        //    my.Name ??= o.Name;
        //    my.Address ??= o.Address;
        //    my.Phone ??= o.Phone;
        //    my.Bank_account ??= o.Bank_account;
        //    if(my.Date_registration != o.Date_registration)
        //        my.Date_registration = o.Date_registration;
        //}
    }
}
