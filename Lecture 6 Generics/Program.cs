using System;
using System.Collections.Generic;

namespace Lecture_6_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- 1.Handy -----
            //List<string> poggers = new List<string>();
            //poggers.Add("Lars");
            //poggers.Add("Raymond");
            //poggers.Add("Daniel");
            //poggers.Add("Oliver");
            //poggers.Add("Elias");
            //poggers.Add("Poggie");
            //poggers.Add("Woggie");
            //poggers.Add("Wxggie");

            //string largest = HandyMethods.Max(poggers);

            //Console.WriteLine(largest);

            //int[] toBeCopied = new int[] { 1, 5, 3, 2, 10 };
            //int[] copiedArray = new int[5];

            //HandyMethods.Copy(toBeCopied, copiedArray);

            //foreach (var item in copiedArray)
            //{
            //    Console.WriteLine(item);
            //}

            //HandyMethods.Shuffle(toBeCopied);
            //foreach (var item in toBeCopied)
            //{
            //    Console.WriteLine(item);
            //}

            //----- 2-4.Pair ----- 

            //Pair<string, bool> pog = new Pair<string, bool>("pog", true);
            //Console.WriteLine(pog.RaymondsType);
            //Console.WriteLine(pog.LarsType);

            //Pair<bool, string> champ = pog.Swap();
            //Console.WriteLine(champ.RaymondsType);
            //Console.WriteLine(champ.LarsType);

            //Pair<bool, string> ølMand = new Pair<bool, string>(true, "Hello World");
            //Console.WriteLine(ølMand.RaymondsType);
            //Console.WriteLine(ølMand.LarsType);

            //var ølMand2 = ølMand.SetFirst(42);
            //Console.WriteLine(ølMand2.RaymondsType);
            //Console.WriteLine(ølMand2.LarsType);

            // ----- 5. Dict -----

            Dict<string, int> dictionary = new Dict<string, int>(new List<Pair<string, int>>());
            dictionary.Dic.Add(new Pair<string, int>("Daniel", 30));
            dictionary.Dic.Add(new Pair<string, int>("Raymond", 21));
            dictionary.Dic.Add(new Pair<string, int>("Lars", 22));
            dictionary.Dic.Add(new Pair<string, int>("Oliver", 21));
            dictionary.Dic.Add(new Pair<string, int>("Elias", 23));
            dictionary.Put("Tobias", 21);
            dictionary.Put("Tobias", 22);

            foreach (var item in dictionary.Dic)
            {
                Console.WriteLine($"{item.RaymondsType} : {item.LarsType}");
            }
        }
    }
}
