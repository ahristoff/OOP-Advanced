using System;
using System.Linq;

namespace _2_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ListyIterator<string>();

            var input = Console.ReadLine();

            while (input != "END")
            {
                var com = input.Split();
                var inputTokens = com.Skip(1).ToList();

                try
                {
                    switch (com[0])
                    {
                        case "Create":
                            list.Create(inputTokens); break;

                        case "Move":
                            Console.WriteLine(list.Move()); break;

                        case "HasNext":
                            Console.WriteLine(list.HasNext()); break;

                        case "Print":
                            list.Print(); break;

                        case "PrintAll":
                            Console.WriteLine((string.Join(" ", list))); break;

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
        }
    }
}
