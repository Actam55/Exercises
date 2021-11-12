using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9_Testing
{
    class String
    {
        public char[] CharString { get; set; }
        public String(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = CharString[i];
            }
        }
        public char CharAt(int index)
        {
            return CharString[index];
        }
        public int Length()
        {
            return CharString.Length;
        }
        public char[] Substring(int a, int b)
        {
            char[] newString = new char[CharString.Length - (a + b)];
            int j = 0;
            for (int i = a; i < b; i++)
            {
                newString[j] = CharString[i];
                j++;
            }
            return newString;
        }
        public char[] ToLower()
        {
            for (int i = 0; i < CharString.Length; i++)
            {
                CharString[i].ToLower($"{CharString.CharAt(i)}");
            }
        }
    }
}
