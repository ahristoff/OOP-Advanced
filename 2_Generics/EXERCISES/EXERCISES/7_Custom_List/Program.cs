using System;

namespace _7_Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var list = new Box<string>();
       
            while (input != "END")
            {
                var comand = input.Split();

                try
                {
                    switch (comand[0])
                    {
                        case "Add":
                            list.AddElement(comand[1]); break;

                        case "Remove":
                            list.RemoveElement(int.Parse(comand[1])); break;

                        case "Contains":
                            list.ContainElement(comand[1]); break;

                        case "Swap":
                            list.SwapElement(int.Parse(comand[1]), int.Parse(comand[2])); break;

                        case "Greater":
                            list.GreaterElement(comand[1]); break;

                        case "Max":
                            list.MaxElement(); break;

                        case "Min":
                            list.MinElement(); break;

                        case "Print":
                            list.PrintElements(); break;
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentException("Invalid Input");
                }

                input = Console.ReadLine();
            }
        }
    }
}
