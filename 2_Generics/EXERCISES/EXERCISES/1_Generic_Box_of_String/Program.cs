using System;

namespace _1_Generic_Box_of_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine();

                var box = new Box<string>(element);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
