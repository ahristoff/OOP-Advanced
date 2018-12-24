using DependencyInversion.Models;
using System;
using System.Linq;

namespace _3_DependencyInversion
{
    class Program
    {
        public static void Main()
        {
            var calculator = new PrimitiveCalculator();

            var command = Console.ReadLine();
            while (command != "End")
            {
                var input = command.Split();              

                if (input[0] == "mode")
                {
                    var strategy = input[1][0];
                    calculator.ChangeStrategy(strategy);                  
                }
                else
                {
                    var operands = input.Select(int.Parse).ToArray();
                    var result = calculator.PerformCalculation(operands[0], operands[1]);
                    Console.WriteLine(result);
                }


                command = Console.ReadLine();
            }
        }
       
    }
}
