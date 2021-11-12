using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9_Testing
{
    public class Circle
    {
        public Circle(int centerX, int centerY, int radius)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }

        public int CenterX { get; set; }
        public int CenterY { get; set; }
        public int Radius { get; set; }

        public bool IsPointInCircle(int x, int y)
        {
            return (Math.Pow((CenterX - x), 2) + Math.Pow((CenterY - y), 2) < Math.Pow(Radius, 2)); 
        }
        public bool CirclesOverlap(Circle circle)
        {
            return Math.Pow((CenterX - circle.CenterX), 2) + Math.Pow((CenterY - circle.CenterY), 2) <= Math.Pow(Radius + circle.Radius, 2);
        }
    }
}
