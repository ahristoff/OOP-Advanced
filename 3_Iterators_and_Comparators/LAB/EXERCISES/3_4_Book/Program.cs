using System;
using System.Collections.Generic;

namespace _Lab_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem 3
            var authors = new string[] { "Dorothy Sayers", "Robert Eustace"};

            Book bookOne = new Book("Animal Farm", 2003, "George Orwell", "Robert Eustace");
            Book bookTwo = new Book("The Documents in the Case", 2002,  authors);
            Book bookThree = new Book("The Documents in the Case", 1930);
          
            Library libraryOne = new Library(bookOne, bookTwo, bookThree);

            foreach (var x in libraryOne)
            {
                Console.WriteLine(string.Join(", ", x.ToString()));
            }

            //problem 4
            Console.WriteLine();

            SortedSet<Book> libraryTwo = 
                new SortedSet<Book>(new Book[] { bookOne, bookTwo, bookThree }, new BookComparator());

            foreach (var x in libraryTwo)
            {
                Console.WriteLine(string.Join(", ", $"{x.Title} - {x.Year}"));
            }
        }
    }
}
