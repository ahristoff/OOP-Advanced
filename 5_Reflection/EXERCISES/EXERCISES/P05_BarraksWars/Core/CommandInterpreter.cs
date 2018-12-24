using _05BarracksFactory.Core.Factories;
using _05BarracksFactory.Contracts;
using _05BarracksFactory.Core;
using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace _05BarracksFactory.Core
{  
    public class CommandInterpreter : ICommandInterpreter
    {
        //private IRepository repository;
        //private IUnitFactory unitFactory;

        private IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;         
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            Assembly assembly = Assembly.GetCallingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(t => t.Name.ToLower() == commandName + "command");

            if (commandType == null)
            {
                throw new ArgumentException("Invalid Command!");
            }

            if (!typeof(IExecutable).IsAssignableFrom(commandType))
            {
                throw new ArgumentException($"{commandName} is not a command");
            }

            var fieldsToInject = commandType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .Where(f => f.CustomAttributes.Any(ca => ca.AttributeType == typeof(InjectAttribute))).ToArray();

            object[] injectArgs = fieldsToInject 
                .Select(f => this.serviceProvider.GetService(f.FieldType)).ToArray();

            IExecutable instance = 
                (IExecutable)Activator
                .CreateInstance(commandType, new object[] { data }.Concat(injectArgs).ToArray());

            return instance;
        }
    }
}
