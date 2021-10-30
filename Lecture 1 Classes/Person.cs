using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_Classes
{
    class Person
    {
        private string _fornavn;
        public string Fornavn
        {
            get { return _fornavn; }
            set
            {
                _fornavn = char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        private string _efternavn;
        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                _efternavn = char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        public int Alder { get; set; }
        public Person Mor { get; set; }
        public Person Far { get; set; }
        public Person(string fornavn, string efternavn, int alder, Person mor = null, Person far = null)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            Alder = alder;
            Mor = mor;
            Far = far;
            PersonID = Guid.NewGuid();
        }
        public Guid PersonID {get; set;}
    }
}
