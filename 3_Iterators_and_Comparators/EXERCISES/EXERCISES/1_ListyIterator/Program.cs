using System;
using System.Linq;

namespace _1_ListyIterator
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
                            if (inputTokens.Any())
                            {                
                                    list.Create(inputTokens);    
                            }
                            break;

                        case "Move":
                            list.Move(); break;

                        case "HasNext":
                            list.HasNext(); break;

                        case "Print":
                            list.Print(); break;

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
