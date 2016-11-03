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
            classPerson1.Person P1 = new classPerson1.Person();
            classPerson2.Person P2 = new classPerson2.Person();
            classPerson1.Person FPerson = new classPerson1.Person();
            classPerson2.Person LPerson = new classPerson2.Person();

            P1.Name = "Ivan";
            P1.Surname = "Ivanov";

            P2.FirstName = "Kolya";
            P2.lastName = "Nisk";

            FPerson.Name = "Ivan";
            FPerson.Surname = "Ivanov";

            LPerson.FirstName = "Kolya";
            LPerson.lastName = "Nisk";

            bool equals = P1.Comparison(P2);
            equals = P1.Comparison(P1);
            equals = P1.Comparison(P2);
            equals = P1.Comparison(P2);

            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        public static bool Comparison(this classPerson1.Person Person1, classPerson2.Person Person2)
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

        public static bool Comparison(this classPerson1.Person Person1, classPerson1.Person FirstPerson)
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

        public static bool Comparison(this classPerson2.Person Person2, classPerson2.Person LastPerson)
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

        public static bool Comparison(this classPerson2.Person Person2, classPerson1.Person Person1)
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
