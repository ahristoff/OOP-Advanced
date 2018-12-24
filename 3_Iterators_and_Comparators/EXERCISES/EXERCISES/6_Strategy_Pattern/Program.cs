using _6_Strategy_Pattern.Comparators;
using System;
using System.Collections.Generic;

namespace _6_Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameComparator = new SortedSet<Person>(new NameComparator());
            var ageComparator = new SortedSet<Person>(new AgeComparator());

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);

                nameComparator.Add(person);
                ageComparator.Add(person);
            }

            Console.WriteLine();

            foreach (var x in nameComparator)
            {
                Console.WriteLine(x);
            }
          
             foreach (var x in ageComparator)
            {
                Console.WriteLine(x);
            }
        }
    }
}
