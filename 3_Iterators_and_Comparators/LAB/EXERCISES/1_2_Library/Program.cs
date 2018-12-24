using System;
using System.Collections.Generic;

namespace _1_2_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library(bookTwo, bookThree);
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);
            Library libraryThree = new Library();

            Console.WriteLine("libraryOne contains: ");

            foreach (var x in libraryOne)
            {
                Console.WriteLine($"{x.Title} -> {x.Year}");
                Console.Write("---");
                Console.WriteLine(x.Authors.Count == 0 ? "unknown name" : string.Join(", ", x.Authors));
            }

            Console.WriteLine();
            Console.WriteLine("libraryTwo contains: ");

            foreach (var x in libraryTwo)
            {
                Console.WriteLine($"{x.Title} -> {x.Year}");
                Console.Write("---");
                Console.WriteLine(x.Authors.Count == 0 ? "unknown name" : string.Join(", ", x.Authors));
            }

            Console.WriteLine();
            Console.WriteLine("libraryThree contains: ");

            foreach (var x in libraryThree)
            {
                Console.WriteLine($"{x.Title} -> {x.Year}");
                Console.Write("---");
                Console.WriteLine(x.Authors.Count == 0 ? "unknown name" : string.Join(", ", x.Authors));
            }
        }
    }
}
