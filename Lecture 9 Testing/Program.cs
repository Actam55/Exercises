using System;

namespace Lecture_9_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new(0, 0, 5);
            Circle circleB = new(2, 2, 5);
            Console.WriteLine(circleA.IsPointInCircle(2, 2));
            Console.WriteLine(circleA.CirclesOverlap(circleB));
            Console.WriteLine();
        }
    }
}
