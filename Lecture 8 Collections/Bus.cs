using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    class Bus : MotorVehicle
    {
        public Bus()
        {
            _fuel = Fuel.Diesel;
        }
        public int NumSeats { get; set; }
        public override Fuel Fuel
        {
            set { } //do nothing - only diesel is allowed
        }

    }
}
