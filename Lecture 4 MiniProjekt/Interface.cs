using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt_Lecture_4
{
    public interface IMenuItem
    {
        public string Titel { get; set; }
        public void Select();
    }
}
