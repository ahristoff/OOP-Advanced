using System;
using System.Linq;

namespace _3_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomStack<string>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var com = input.Split(new string[] {", ", " "}, StringSplitOptions.RemoveEmptyEntries);
                var inputTokens = com.Skip(1).ToList();
                try
                {
                    switch (com[0])
                    {
                        case "Push":
                            list.Push(inputTokens); break;

                        case "Pop":
                            list.Pop(); break;

                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Join("\n", list));
            }
        }
    }
}
