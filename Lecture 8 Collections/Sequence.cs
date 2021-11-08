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
        public Sequence(int start, int skip, int count)
        {
            Start = start;
            Skip = skip;
            Count = count;
            data = ShowSequence();
            foreach (int item in data)
            {
                Console.WriteLine(item);
            }
        }

        public List<int> data { get; set;}
        public int Start { get; set; }
        public int Skip { get; set; }
        public int Count { get; set; }

        public List<int> ShowSequence()
        {
            int n = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < Count;)
            {
                if (n == 0)
                {
                    list.Add(Start);
                    n = Start;
                    i++;
                }
                else if (n % Skip == 0)
                {
            
                }
                else
                {
                    list.Add(n);
                    i++;
                }
                n++;
            }
            return list;
        }



        public IEnumerator<int> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //public static void ShowSequence(IEnumerable<int> e)
        //{
        //    IEnumerator<int> i = e.GetEnumerator();
        //    int n = 0;
        //    List<int> list = new List<int>();
        //    for (int i = 0; i < Count; i++)
        //    {
        //        if (n == 0)
        //        {
        //            list.Add(Start);
        //            n = Start;
        //        }
        //        else if (n % Skip == 0)
        //        {
        //
        //        }
        //        else
        //        {
        //            list.Add(n);
        //        }
        //
        //        //Console.WriteLine(i);
        //    }
        //    return list;
        //}
    }
}
