using System;
using System.Collections.Generic;

namespace Lecture_7_Delegates
{
    class Program
    {
        public delegate string stringJoin(string l, string r);

        public delegate T allJoin<T>(T l, T r);
        static string concatString(string l, string r) { return l + r; }
        static string joinThree(string first, string second, string third, stringJoin stringJoiner)
        {
            return stringJoiner(stringJoiner(first, second), third);
        }

        static string joinAllStrings(List<string> list, stringJoin stringJoiner)
        {
            string result = list[0];
            result = stringJoiner(list[0], list[1]);
            for (int i = 1; i < list.Count; i++)
            {
                result = stringJoiner(result, list[i]);
            }
            return result;
        }

        static T joinAll<T>(List<T> list, allJoin<T> joiner)
        {
            T result = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                result = joiner(result, list[i]);
            }
            return result;
        }

        static bool Exists<T>(Predicate<T> f, T[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (f(a[i]))
                {
                    return true;
                }
            }
            return false;
        }

        static T twice<T>(Func<T, T> f, T v)
        {
            return f(f(v));
        }
        static void Main(string[] args)
        {
            //stringJoin test = concatString;
            //Console.WriteLine(test("Hello ", "Delegates"));
            //
            //-----------------------------------------------
            //
            //Console.WriteLine(joinThree("a", "b", "c", (l, r) => l + r));  // abc
            //Console.WriteLine(joinThree("a", "b", "c", (l, r) => l + "." + r));  // a.b.c
            //Console.WriteLine(joinThree("a", "b", "c", (l, r) => l)); // a
            //
            //-----------------------------------------------
            //
            //Console.WriteLine(joinAllStrings(new List<string> { "a", "b", "c", "d" }, (l, r) => l + "." + r)); // a.b.c.d
            //Console.WriteLine(joinAllStrings(new List<string> { "a", "b", "c", "d" }, (l, r) => l + r));  // abcd
            //Console.WriteLine(joinAllStrings(new List<string> { "a", "b", "c", "d" }, (l, r) => r));  // d
            //
            //-----------------------------------------------
            //
            //Console.WriteLine(joinAll(new List<int> { 1, 2, 3, 4 }, (a, b) => a + b)); // 10
            //Console.WriteLine(joinAll(new List<int> { 1, 2, 3, 4 }, (a, b) => a * b)); // 24
            //Console.WriteLine(joinAll(new List<string> { "a", "b", "c", "d" }, (l, r) => l + "." + r)); // a.b.c.d
            //
            //-----------------------------------------------
            //
            //Console.WriteLine(Exists(f => f % 2  == 0, new int[] {1, 4, 3, 10}));
            //
            //-----------------------------------------------
            //
            //Console.WriteLine(twice(x => x * 2, 1));
        }
    }
}
