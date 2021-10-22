using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6_Generics
{
    class Pair<T1, T2>
    {
        public T1 RaymondsType { get; }
        public T2 LarsType { get; }

        public Pair(T1 raymondstype, T2 larstype)
        {
            RaymondsType = raymondstype;
            LarsType = larstype;
        }

        public Pair<T2, T1> Swap()
        {
            return new Pair<T2, T1>(LarsType, RaymondsType);
        }
        
        public Pair<T, T2> SetFirst<T>(T C)
        {
            return new Pair<T, T2>(C, LarsType);
        }

        public Pair<T1, T> SetSecond<T>(T C)
        {
            return new Pair<T1, T>(RaymondsType, C);
        }
    }
}
