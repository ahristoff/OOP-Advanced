using System;
using System.Collections.Generic;

namespace _5_Generic_Count_Method_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
            var list = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine();
                list.Add(element);
            }

            var baseElement = Console.ReadLine();

            box.Compare(baseElement, list);
        }
    }
}
