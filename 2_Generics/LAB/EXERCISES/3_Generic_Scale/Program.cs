using System;

namespace _3_Generic_Scale
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale<int> scale1 = new Scale<int>(78, 5);
            Scale<string> scale2 = new Scale<string>("werr", "wer");
            Scale<int> scale3 = new Scale<int>(25, 25);

            Console.WriteLine(scale1.GetHeavier());
            Console.WriteLine(scale2.GetHeavier());
            Console.WriteLine(scale3.GetHeavier());
        }
    }
}
