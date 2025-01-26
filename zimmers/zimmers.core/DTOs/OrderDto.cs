using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zimmers.core.Entities;

namespace zimmers.core.DTOs
{
    public class OrderDto
    {
        public int Id { get; private set; }
        public int UserId { get; set; }
        public int ZimmerId { get; set; }
        public DateTime Starting_date { get; set; }
        public int Num_of_nights { get; set; }
        public int Total_sum { get; set; }
    }
}
