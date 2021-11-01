using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt_Lecture_4
{
    public class InfiniteMenu : Menu, IMenuItem
    {
        public InfiniteMenu(string titel) : base(titel)
        {
        }
        public void Select()
        {
            Add(new InfiniteMenu("Poggers1"));
            Start();
        }
    }
}
