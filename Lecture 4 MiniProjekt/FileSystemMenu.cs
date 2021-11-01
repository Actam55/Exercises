using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt_Lecture_4
{
    public class FileSystemMenu : Menu, IMenuItem
    {
        public DirectoryInfo DirectoryInfo { get; }

        public void Select()
        {
            foreach (var item in DirectoryInfo.EnumerateDirectories())
            {
                Add(new FileSystemMenu(item.ToString(), new DirectoryInfo(item.ToString())));
            }
            Start();
        }

        public FileSystemMenu(string titel, DirectoryInfo di) : base(titel)
        {
            DirectoryInfo = di;
        }
    }
}
