using System;

namespace _1_Box
{
    public class Program
    {
        public static void Main()
        {
            Box<string> boxString = new Box<string>();
            boxString.Add("abc");
            boxString.Add("def");
            boxString.Add("ghj");
            Console.WriteLine(boxString.Remove());
            boxString.Add("klm");
            boxString.Add("nop");
            Console.WriteLine(boxString.Remove());
            Console.WriteLine(boxString.Count);
            Console.WriteLine();

            Box<Cat> boxCat = new Box<Cat>();
            boxCat.Add(new Cat("Pesho"));
            boxCat.Add(new Cat("Gosho"));
            boxCat.Add(new Cat("Ivan"));
            Console.WriteLine(boxCat.Remove());
            boxCat.Add(new Cat("Dragan"));
            Console.WriteLine(boxCat.Remove());
            Console.WriteLine(boxCat.Count);
            Console.WriteLine();

            Box<int> boxInt = new Box<int>();
            boxInt.Add(1);
            boxInt.Add(2);
            boxInt.Add(3);
            Console.WriteLine(boxInt.Remove());
            boxInt.Add(4);
            boxInt.Add(5);
            boxInt.Add(6);
            Console.WriteLine(boxInt.Remove());
            Console.WriteLine(boxInt.Count);
        }
    }
}

