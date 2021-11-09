using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    class PredicateEnumerator<T> : IEnumerator<T>
    {
        private List<T> list;
        private int position = -1;

        public PredicateEnumerator(List<T> list, Predicate<T> f)
        {
            this.list = list.Where(item => f(item)).ToList();
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
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return (++position < list.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
