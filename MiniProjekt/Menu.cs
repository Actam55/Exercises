using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt_Lecture_4
{
    public class Menu
    {
        private List<MenuItem> MenuItem { get; set; } = new List<MenuItem>();
        private string _titel;
        private int _cursor;
        private int CursorTop;
        private int CursorLeft;

        public int Cursor
        {
            get { return _cursor; }
            set { 
                if(value < 0)
                {
                    value = MenuItem.Count-1;
                }
                _cursor = value % MenuItem.Count; }
        }

        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        public Menu(string titel)
        {
            Titel = titel;
        }
        public void Start()
        {
            CursorTop = Console.CursorTop;
            CursorLeft = Console.CursorLeft;
            Draw();
            HandelInput();
        }
        public void Add(IMenuItem item)
        {
            MenuItem.Add(item);
        }
        private void Draw()
        {
            Console.SetCursorPosition(CursorLeft, CursorTop);
            foreach (var item in MenuItem)
            {
                if (MenuItem[Cursor] == item)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(item.Titel);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                    Console.WriteLine(item.Titel);
            }
        }
        private void HandelInput()
        {
            bool open = true;
            while (open)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        Cursor--;
                        Draw();
                        break;
                    case ConsoleKey.DownArrow:
                        Cursor++;
                        Draw();
                        break;
                    case ConsoleKey.Enter:
                        MenuItem[Cursor].Select();
                        break;
                    case ConsoleKey.Escape:
                        open = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
