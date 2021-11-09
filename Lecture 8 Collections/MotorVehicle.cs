using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    abstract class MotorVehicle
    {
        protected Fuel _fuel;
        public string Make { get; set; } //VW, Audi, Skoda...
        public string Model { get; set; } //Golf, Polo, A3, Fabia, etc.
        public int Year { get; set; }
        public decimal Price { get; set; }
        public virtual Fuel Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public override string ToString()
        {
            return $"Make: {Make}";
        }
    }
}
