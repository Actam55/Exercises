using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9_Testing
{
    class Vector2D
    {
        public Vector2D(int a, int b)
        {
            A = a;
            B = b;
        }
        public int A { get; set; }
        public int B { get; set; }


        public Vector2D VactorAdd(Vector2D vector)
        {
            return new Vector2D((vector.A + A), (vector.B + B));
        }
        public Vector2D VectorScalar(int scalar)
        {
            return new Vector2D(A * scalar, B * scalar);
        }
        public int VectorCrossProduct(Vector2D vector)
        {
            return ((A * vector.B) - (B * vector.A));
        }
    }
}
