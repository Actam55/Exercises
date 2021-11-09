using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    public class Sequence : IEnumerable<int>
    {
        public int Start { get; set; }
        public int Skip { get; set; }
        public int Count { get; set; }
        public List<int> Data { get; set; }
        public Sequence(int start, int skip, int count)
        {
            Start = start;
            Skip = skip;
            Count = count;
            Data = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                Data.Add(Start + Skip * i);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return Data.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
