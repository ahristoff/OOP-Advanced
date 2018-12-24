using System;
using System.Collections.Generic;

namespace _Lab_3_4
{
    public class Book : IComparable<Book>
    {
       
        public Book(string title, int year, params string[] authors)
        {
            Authors = authors;
            Title = title;
            Year = year;
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
            int result = this.Title.CompareTo(other.Title);

            if (result == 0)
            {
                result = other.Year.CompareTo(this.Year);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}

