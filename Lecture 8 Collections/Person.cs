using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    class Person
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name, -10} Weight: {Weight, -10} Age: {Age, -10}";
        }
    }
}
