using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Inheritance
{
    class WeekdayRate : ParkingRate
    {
        public override decimal CalculateRate()
        {
            return 3;
        }
    }
}
