using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    namespace classPerson1
    {
        class Person
        {
            public string Name, Surname;
        }
    }

    namespace classPerson2
    {
        class Person
        {
            public string FirstName, lastName;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            classPerson1.Person p1 = new classPerson1.Person();
            classPerson1.Person fPerson = new classPerson1.Person();
            classPerson2.Person lPerson = new classPerson2.Person();

            p1.Name = "Ivan";
            p1.Surname = "Ivanov";

            p2.FirstName = "Kolya";
            p2.lastName = "Nisk";

            fPerson.Name = "Ivan";
            fPerson.Surname = "Ivanov";

            lPerson.FirstName = "Kolya";
            lPerson.lastName = "Nisk";

            bool equals = p1.Compare(p2);
            equals = p1.Compare(p1);
            equals = p1.Compare(p2);
            equals = p1.Compare(p2);

            Console.WriteLine("");

            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        public static bool Compare(this classPerson1.Person Person1, classPerson2.Person Person2)
        {
            if (Person1.Name == Person2.FirstName)
            {
                return true;
            }
            else if (Person1.Surname == Person2.lastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Compare(this classPerson1.Person Person1, classPerson1.Person FirstPerson)
        {
            if (Person1.Name == FirstPerson.Surname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Compare(this classPerson2.Person Person2, classPerson2.Person LastPerson)
        {
            if (Person2.FirstName == LastPerson.lastName)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Compare(this classPerson2.Person Person2, classPerson1.Person Person1)
        {
            if (Person2.FirstName == Person1.Name)
            {
                return true;
            }
            else if (Person2.lastName == Person1.Surname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
