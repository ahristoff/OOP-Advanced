using System;
using _04BarracksFactory.Contracts;

namespace _04BarracksFactory.Core
{
    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;
        private ICommandInterpreter commandInterpreter;

        public Engine(IRepository repository, IUnitFactory unitFactory, ICommandInterpreter commandInterpreter)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
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

                    var instance = commandInterpreter.InterpretCommand(data);

                    var type = typeof(IExecutable);

                    try
                    {
                        var method = type.GetMethod("Execute");
                        var res = method.Invoke(instance, new object[] { });
                        Console.WriteLine(res);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                        //throw new ArgumentException("No such units in repository");
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
