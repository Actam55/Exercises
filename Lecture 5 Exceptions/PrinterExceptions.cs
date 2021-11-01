using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Lecture_5
{
    public class OutOfPaperExceptions : Exception
    {
        public OutOfPaperExceptions(string message) : base(message)
        {
        }
    }

    public class OutOfTonerException : Exception
    {
        public OutOfTonerException(string message) : base(message)
        {
        }
    }

    public class PaperJamException : Exception
    {
        public PaperJamException(string message) : base(message)
        {
        }
    }
}
