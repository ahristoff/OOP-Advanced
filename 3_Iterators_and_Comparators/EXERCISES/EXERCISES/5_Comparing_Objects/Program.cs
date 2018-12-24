using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedPerson = new List<Person>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var inputTakens = input.Split();

                var name = inputTakens[0];
                var age = int.Parse(inputTakens[1]);
                var town = inputTakens[2];
                var person = new Person(name, age, town);

                sortedPerson.Add(person);

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine()) - 1;

            if (n >= 0 && n < sortedPerson.Count)
            {
                var person = sortedPerson[n];

                var machPersons = sortedPerson.Count(sp => sp.CompareTo(person) == 0);

                if (machPersons > 1)
                {
                    Console.WriteLine($"{machPersons} {sortedPerson.Count - machPersons} {sortedPerson.Count}");
                }

                else if (machPersons == 1)
                {
                    Console.WriteLine("No matches");
                }                
            }
        }
    }
}
