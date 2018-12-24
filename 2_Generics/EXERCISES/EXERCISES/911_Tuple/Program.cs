using System;

namespace _911_Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            // <string string> <string>
            var inputTokens = Console.ReadLine().Split(' ');
            var tuple1 = new Tuple<string, string>(
                                    $"{inputTokens[0]} {inputTokens[1]}",
                                    inputTokens[2]);
            // string int
            inputTokens = Console.ReadLine().Split(' ');
            var tuple2 = new Tuple<string, int>(
                                    inputTokens[0],
                                    int.Parse(inputTokens[1]));
            // int double
            inputTokens = Console.ReadLine().Split(' ');
            var tuple3 = new Tuple<int, double>(
                                    int.Parse(inputTokens[0]),
                                    double.Parse(inputTokens[1]));

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
