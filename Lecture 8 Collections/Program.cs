using System;
using System.Collections.Generic;

namespace Lecture_8_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //RandomNNumbers nums = new RandomNNumbers(2, 10, 100, 20);
            //
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            SortedList<string> list = new();
            list.Add("69");
            list.Add("Raymond");
            list.Add("420");
            list.Add("88");
            list.Add("Tobias");

            //IEnumerator<string> reversedInstructions = list.GetElementsReversed();
            //
            //while (reversedInstructions.MoveNext())
            //{
            //    Console.WriteLine(reversedInstructions.Current);
            //}

            IEnumerator<string> filteredInstructions = list.GetElements(f => f.Contains("o"));

            while (filteredInstructions.MoveNext())
            {
                Console.WriteLine(filteredInstructions.Current);
            }
        }
    }
}
