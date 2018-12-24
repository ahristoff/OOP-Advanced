using _910_CreateCustomClassAttribute.Attributes;
using _910_CreateCustomClassAttribute.Models;
using System;

namespace _910_CreateCustomClassAttribute
{

    [Custom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class Program
    {
        public static void Main()
        {
            var customAttributes = typeof(Weapon).GetCustomAttributes(false);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END") break;

                PrintCommand(customAttributes, command);
            }
        }

        private static void PrintCommand(object[] attributes, string command)
        {

            foreach (CustomAttribute x in attributes)
            {

                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"{command}: {x.Author}"); break;

                    case "Revision":
                        Console.WriteLine($"{command}: {x.Revision}"); break;
                       
                    case "Description":
                        Console.WriteLine($"Class {command.ToLower()}: {x.Description}"); break;
                       
                    case "Reviewers":
                        Console.WriteLine($"{command}: {string.Join(", ", x.Reviewers)}"); break;
                       
                    default: break;
                }
            }
        }
    }
}