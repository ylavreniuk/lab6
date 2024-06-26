using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Program
    {
        interface Person
        {
            void PrintCountryName();
            void Speak();
        }

        class Ukranian : Person
        {
            public void PrintCountryName()
            {
                Console.WriteLine("Україна");
            }
            public void Speak()
            {
                Console.WriteLine("Українська");
            }
        }
        class Italian : Person
        {
            public void PrintCountryName()
            {
                Console.WriteLine("Італія");
            }
            public void Speak()
            {
                Console.WriteLine("Італійська");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person person = new Ukranian();
            Console.WriteLine("Українець");
            person.PrintCountryName();
            person.Speak();
            Console.WriteLine("Італієць");
            person = new Italian();
            person.PrintCountryName();
            person.Speak();
            Console.ReadKey();
        }
    }
}