using System;

namespace _8_Custom_List_Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var list = new Box<string>();
            var sortList = new Sorter();

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
                       
                        case "Sort":
                            list = sortList.Sort(list); break;
    
                        default:
                            break;
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
