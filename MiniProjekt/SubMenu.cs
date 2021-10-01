using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt_Lecture_4
{
    public class SubMenu : Menu, IMenuItem
    {
        public SubMenu(string titel) : base(titel)
        {
        }
        public void Select()
        {
            Start();
        }
    }
}
