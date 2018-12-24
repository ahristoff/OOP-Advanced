using System;

namespace _2_Generic_Array_Creator
{
    public class Program
    {
        public static void Main()
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");    
            Console.WriteLine(string.Join("\n", strings));

            int[] integers = ArrayCreator.Create(10, 33);
            Console.WriteLine(string.Join("\n", integers));
        }
    }
}
