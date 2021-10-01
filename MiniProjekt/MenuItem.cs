using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt_Lecture_4
{
    public class MenuItem : Menu, IMenuItem
    {
        private string _content;

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public MenuItem(string titel, string content) : base(titel)
        {
            Content = content;
        }

        public void Select()
        {
            Console.Write($"\r");
            Console.Write(Content);
        }

    }
}
