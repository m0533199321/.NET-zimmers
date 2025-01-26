using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zimmers.core.DTOs
{
    public class OwnerDto
    {
        public int Id { get; private set; }
        public string Tz { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Bank_account { get; set; }
        public DateTime Date_registration { get; set; }
    }
}
