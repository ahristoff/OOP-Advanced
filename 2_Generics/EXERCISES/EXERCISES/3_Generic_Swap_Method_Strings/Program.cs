using System;
using System.Linq;

namespace _3_Generic_Swap_Method_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var list = new Box<string>();
           
            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine();
                list.AddElement(element);
            }

            var num = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.SwapElement(num[0], num[1]);
            list.PrintElements();
        } 
    }
}
