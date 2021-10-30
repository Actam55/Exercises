using System;
using System.IO;

namespace Lecture_1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mormor = new Person("mormor", "mormor", 70);
            Person morfar = new Person("morfar", "morfar", 70);
            Person farfar = new Person("farfar", "farfar", 70);
            Person farmor = new Person("farmor", "farmor", 70);
            Person poul = new Person("poul", "hansen", 55, farmor, farfar);
            Person pauline = new Person("pauline", "hansen", 42, mormor, morfar);
            Person lars = new Person("lars", "hansen", 22, pauline, poul);

            //PersonPrinter.PrintPerson(lars);
            //PersonPrinter.PrintAncestry(lars);

            DirectoryInfo di = new DirectoryInfo(@"D:\DirectoryTest");
            DirectoryInfo[] dirs = di.GetDirectories();

            foreach (var item in dirs)
            {
                DirectoryInfo[] subDirs = item.GetDirectories(); 
                Console.WriteLine($"Folder: {item.Name} Contains {subDirs.Length} sub folders and {item.GetFiles().Length} files");
            }
        }
    }
}