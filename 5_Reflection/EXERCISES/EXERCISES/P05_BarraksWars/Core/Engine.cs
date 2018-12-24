using System;
using _05BarracksFactory.Contracts;
using System.Reflection;
using System.Linq;

namespace _05BarracksFactory.Core
{
    class Engine : IRunnable
    {        
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {          
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    IExecutable command = commandInterpreter.InterpretCommand(data, commandName);

                    var method = typeof(IExecutable).GetMethod("Execute"); 

                    try
                    {
                        var res = method.Invoke(command, new object[] { });
                        Console.WriteLine(res); 
                    }
                    catch (Exception)
                    {
                        throw new ArgumentException("No such units in repository.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }     
    }
}