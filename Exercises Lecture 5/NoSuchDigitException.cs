using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    class NoSuchDigitException : Exception
    {
        public NoSuchDigitException(string message) : base(message)
        {

        }
    }
}
