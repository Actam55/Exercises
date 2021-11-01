using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    class IllegalDigitsException : Exception
    {
        public IllegalDigitsException(string message) : base(message)
        {
        }
    }
}
