using System;
using System.Collections.Generic;

namespace _6_Generic_Count_Method_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<double>();
            var list = new List<double>();

            int n = int.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
                var element = double.Parse(Console.ReadLine());
                list.Add(element);
            }

            var baseElement = double.Parse(Console.ReadLine());
            box.Compare(baseElement, list);
        }
    }
}
