using System.Collections.Generic;

namespace _1_2_Library
{
    public class Book
    {
       
        public Book(string title, int year, params string[] authors)
        {
            Authors = authors;
            Title = title;
            Year = year;
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; }
    }
}

