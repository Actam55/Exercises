using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Inheritance
{
    class Ticket
    {
        public decimal Price { get; set; }
        public int Rate { get; set; }

        public Ticket(decimal price, int rate)
        {
            Price = price;
            Rate = rate;
        }
    }
}
