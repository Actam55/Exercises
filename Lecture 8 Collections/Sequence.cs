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
        }

        public List<int> data { get; set;}
        public int Start { get; set; }
        public int Skip { get; set; }
        public int Count { get; set; }

        public static void ShowSequence(IEnumerable<int> e)
        {
            IEnumerator<int> i = e.GetEnumerator();
            



            //int n = 0;
            //List<int> list = new List<int>();
            //for (int i = 0; i < Count; i++)
            //{
            //    if (i == 0)
            //    {
            //        list.Add(Start);
            //        i = Start;
            //    }
            //    else if (i % Skip == 0)
            //    {
            //
            //    }
            //    else
            //    {
            //        list.Add(i);
            //    }
            //
            //    //Console.WriteLine(i);
            //}
            //return list;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //public static void Start(IEnumerable<int> i)
        //{
        //    IEnumerator<int> p = i.GetEnumerator();
        //    p.MoveNext();
        //    Console.WriteLine(p.Current);
        //}
        //public static void Count(IEnumerable<int> i)
        //{
        //    int n = 0;
        //    IEnumerator<int> p = i.GetEnumerator();
        //    while (p.MoveNext())
        //    {
        //        n++;
        //    }
        //    Console.WriteLine(n);
        //}
    }
}
