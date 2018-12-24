using System;
using System.Linq;

namespace _4_Generic_Swap_Method_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var list = new Box<int>();
           
            for (int i = 0; i < n; i++)
            {
                var element = int.Parse(Console.ReadLine());
                list.AddElement(element);
            }

            var num = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.SwapElement(num[0], num[1]);
            list.PrintElements();
        }
    }
}
