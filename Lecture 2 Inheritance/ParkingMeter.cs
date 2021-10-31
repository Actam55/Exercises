using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Inheritance
{
    class ParkingMeter
    {
        public ParkingMeter(ParkingRate rateCalculator)
        {
            RateCalculator = rateCalculator;
        }
        
        public Ticket InsertCoins(decimal coinSum)
        {
            return new Ticket(coinSum, (int)Math.Floor(coinSum /
            RateCalculator.CalculateRate()));
        }
        public ParkingRate RateCalculator { get; set; }
    }
}
