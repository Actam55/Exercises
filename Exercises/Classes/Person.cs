using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Classes
{
    class Person
    {
        private string _Fornavn;
        private Guid _ID;
        public Guid ID { get
            {
                return _ID;
            }
            set
            {
                _ID = Guid.NewGuid();
            } }
        public string Fornavn
        {
            get 
            {
                return _Fornavn;
            }
            set
            {
                if (Char.IsUpper(value[0])){
                    _Fornavn = value;
                }
                else
                {
                    _Fornavn = Char.ToUpper(value[0]) + value.Substring(1);
                }
            }
        }
        public string Efternavn { get; set; }
        public int Alder { get; set; }
        public Person Mor { get; set; }
        public Person Far { get; set; }

        public Person(string fornavn, string efternavn, int alder, Person mor = null, Person far = null)
        {
            _Fornavn = fornavn;
            Efternavn = efternavn;
            Alder = alder;
            Mor = mor;
            Far = far;
            ID = Guid.NewGuid();
        }
    }
}
