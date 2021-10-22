using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_6_Generics
{
    public class HandyMethods
    {
        public static T Max<T>(List<T> list) where T : IComparable<T>
        {
            return list.Max();
        }
        public static T Min<T>(List<T> list) where T : IComparable<T>
        {
            return list.Min();
        }
        public static void Copy<T>(T[] arr1, T[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                throw new Exception("You made a fucky wucky");
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
        }

        public static void Shuffle<T>(T[] array)
        {
            Random rnd = new Random();
            foreach (T item in array)
            {
                int i = rnd.Next(0, array.Length);
                int j = rnd.Next(0, array.Length);
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
}
