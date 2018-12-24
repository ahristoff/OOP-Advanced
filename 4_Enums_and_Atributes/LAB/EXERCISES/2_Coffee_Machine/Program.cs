using System;

namespace _2_Coffee_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {

                string[] inputArgs = input.Split();

                if (inputArgs.Length == 1)
                {
                    machine.InsertCoin(inputArgs[0]);
                }
                else
                {
                    machine.BuyCoffee(inputArgs[0], inputArgs[1]);
                }
            }

            foreach (var x in machine.CoffeesSold)
            {
                Console.WriteLine(x);
            }
        }
    }
}
