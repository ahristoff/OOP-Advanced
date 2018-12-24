using System;
using System.Reflection;
using System.Linq;
using _04BarracksFactory.Contracts;

namespace _04BarracksFactory.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {

        private IRepository repository;
        private IUnitFactory unitFactory;

        public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public IExecutable InterpretCommand(string[] data)
        {
            var type = Assembly.GetExecutingAssembly();

            var command = type.GetTypes().FirstOrDefault(t => t.Name.ToLower() == data[0] + "command");

            if (command == null)
            {
                throw new ArgumentException("this command is not valid");
            }

            if (!typeof(IExecutable).IsAssignableFrom(command))
            {
                throw new ArgumentException("this command is not valid");
            }

            var instance = (IExecutable)Activator.CreateInstance(command, new object[] { data, repository, unitFactory });

            return instance;
        }
    }
}
