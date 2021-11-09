using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    public class ReverseListEnumerator<T> : IEnumerator<T>
    {
        private List<T> list;
        private int position;

        public ReverseListEnumerator(List<T> list)
        {
            this.list = list;
            position = list.Count;
        }

        public T Current
        {
            get
            {
                try
                {
                    return list[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return (--position >= 0);
        }

        public void Reset()
        {
            position = list.Count;
        }
    }
}
