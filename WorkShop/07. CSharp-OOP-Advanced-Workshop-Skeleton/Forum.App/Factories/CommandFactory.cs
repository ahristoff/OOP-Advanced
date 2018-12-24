namespace Forum.App.Factories
{
   
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Forum.App.Contracts;    

    public class CommandFactory : ICommandFactory
	{
        private IServiceProvider serviceProvider;
        public CommandFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

		public ICommand CreateCommand(string commandName)          
		{
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type type = assembly.GetTypes().FirstOrDefault(t => t.Name == commandName + "Command");

            if (type == null)
            {
                throw new ArgumentException($"{commandName}Command not found!");
            }

            if (!typeof(ICommand).IsAssignableFrom(type))
            {
                throw new InvalidOperationException($"{commandName}Command is not an ICommand!");
            }

            ParameterInfo[] ctorParameters = type.GetConstructors().First().GetParameters();
 
            object[] arguments = new object[ctorParameters.Length];

            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = this.serviceProvider.GetService(ctorParameters[i].ParameterType);
            }

            ICommand command = (ICommand)Activator.CreateInstance(type, arguments);

            return command;
        }
	}
}
