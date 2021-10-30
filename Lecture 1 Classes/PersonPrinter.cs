using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_Classes
{
    class PersonPrinter
    {
        static public void PrintPerson(Person person)
        {
            Console.WriteLine($"Name: {person.Fornavn} {person.Efternavn}");
            Console.WriteLine($"Age: {person.Alder}");
            Console.WriteLine($"ID: {person.PersonID}");
        }

        static public void PrintAncestry(Person person)
        {
            if (person.Far != null)
            {
                Console.WriteLine($"{person.Far.Fornavn}");
                PrintAncestry(person.Far);
            }
            if (person.Mor != null)
            {
                Console.WriteLine($"{person.Mor.Fornavn}");
                PrintAncestry(person.Mor);
            }
        }
    }
}
