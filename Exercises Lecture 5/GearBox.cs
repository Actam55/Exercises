using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    class GearBox
    {
        public int Gear { get; set; }
        public int[] LegalGears = { -1, 1, 2, 3, 4, 5};
        public GearBox(int gear)
        {
            Gear = gear;
        }
        public void changeGear(int number)
        {
            int gearDifference = Math.Abs(Gear) - Math.Abs(number);
            if (!LegalGears.Contains(number))
            {
                throw new ArgumentException();
            }
            if (gearDifference != 1 || Gear == number)
            {
                Console.WriteLine(gearDifference);
                throw new IllegalGearChangeException("Cant change that many gears at once");
            }
            Console.WriteLine($"Gear shifted from {Gear} to {number}");
        }
    }
}
