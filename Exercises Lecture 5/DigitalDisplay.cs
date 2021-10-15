using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    class DigitalDisplay
    {
        public int[] Digits = new int[4];
        public DigitalDisplay(int[] digits)
        {
            Digits = digits;
        }


        public int GetDigit(int i)
        {
            if (i < 0 || i > 3)
            {
                throw new NoSuchDigitException("No such digit avaliable");
            }
            Console.WriteLine(Digits[i]);
            return Digits[i];
        }
        public void SetDigit(int i, int v)
        {
            if (i < 0 || i > 3)
            {
                throw new NoSuchDigitException("No such digit avaliable");
            }
            if (v < 0 || v > 9)
            {
                throw new IllegalDigitsException("Digit too high or too low");
            }
            int digit = Digits[i];
            Digits[i] = v;
            Console.WriteLine($"The digit {digit} was changed to {v}");
        }
    }
}
