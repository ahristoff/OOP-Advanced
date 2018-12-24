using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new DataBase(new int[] { 1, 2, 3, 45, 887 });
           
            Console.WriteLine(string.Join(", ", a.Fetch()));
            Console.WriteLine(a.Count);
            Console.WriteLine();
            a.Remove();
            Console.WriteLine(string.Join(", ", a.Fetch()));
            Console.WriteLine(a.Count);
            Console.WriteLine();
            a.Add(777);
            a.Add(888);
            Console.WriteLine(string.Join(", ", a.Fetch()));
            Console.WriteLine(a.Count);
        }
    }
}
