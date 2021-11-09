using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_8_Collections
{
    public class RandomNNumbers : IEnumerable<int>
    {
        private int[] content;

        public RandomNNumbers(int seed, int minimum, int maximum, int n)
        {
            Random rand = new Random(seed);
            content = new int[n];

            for (int i = 0; i < content.Length; i++)
            {
                content[i] = rand.Next(minimum, maximum);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new RandomNumbersEnumerator(content);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
