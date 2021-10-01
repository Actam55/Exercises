using MiniProjekt_Lecture_4;
using System;
using System.IO;

namespace MiniProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Test1");
            mainMenu.Add(new MenuItem("Andreas", "Øl"));
            mainMenu.Add(new MenuItem("Raymond", "Gud"));
            mainMenu.Add(new MenuItem("Daniel", "Code"));
            mainMenu.Add(new MenuItem("Elias", "Nudes"));
            mainMenu.Add(new MenuItem("Tobias", "POE"));
            mainMenu.Add(new MenuItem("Oliver", "Øl"));
            mainMenu.Add(new MenuItem("Lars", "Valorant"));

            SubMenu subMenu = new SubMenu("Sub test");
            subMenu.Add(new MenuItem("Pog", "PogChamp"));
            mainMenu.Add(subMenu);
            mainMenu.Add(new InfiniteMenu("Infinite menu"));
            mainMenu.Add(new FileSystemMenu("Directory", new DirectoryInfo(@"C:\")));


            mainMenu.Start();
        }
    }
}
