using System;
using System.Linq;

namespace _4_Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var list = new Lake(input);

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
