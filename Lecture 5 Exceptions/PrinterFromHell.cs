using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    class PrinterFromHell
    {
        public PrinterFromHell()
        {
        }
        public void print()
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 4);
            switch (number)
            {
                case 1:
                    throw new OutOfPaperExceptions("It's cute");
                case 2:
                    throw new OutOfTonerException("Maybe there is something wrong, my bad");
                case 3:
                    throw new PaperJamException("I made a fuckywucky UwU");
                default:
                    break;
            }
        }
    }
}
