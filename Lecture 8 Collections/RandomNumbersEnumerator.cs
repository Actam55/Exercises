using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    public class RandomNumbersEnumerator : IEnumerator<int>
    {
        private int[] numbers;
        private int position = -1;

        public RandomNumbersEnumerator(int[] numbers)
        {
            this.numbers = numbers;
        }

        object IEnumerator.Current => Current;

        public int Current
        {
            get
            { 
                try
                {
                    return numbers[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return (++position < numbers.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
