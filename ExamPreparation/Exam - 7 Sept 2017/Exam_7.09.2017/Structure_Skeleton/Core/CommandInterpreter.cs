﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class CommandInterpreter : ICommandInterpreter
{    
    public CommandInterpreter(IHarvesterController harvesterController, IProviderController providerController)
    {
        this.HarvesterController = harvesterController;
        this.ProviderController = providerController;
    }

    public IHarvesterController HarvesterController { get; private set; }

    public IProviderController ProviderController { get; private set; }

    public string ProcessCommand(IList<string> args)
    {
        ICommand command = this.CreateCommand(args);

        string result = command.Execute();
        return result;
    }

    public ICommand CreateCommand(IList<string> args)
    {
        string commandName = args[0];  
        
        Assembly commandType = Assembly.GetCallingAssembly();
        var com = commandType.GetTypes().FirstOrDefault(c => c.Name == commandName + "Command");

        if (commandType == null)
        {
            throw new ArgumentException(string.Format(Constants.CommandNotFound, commandName));
        }

        if (!typeof(ICommand).IsAssignableFrom(com)) 
        {
            throw new InvalidOperationException(string.Format(Constants.InvalidCommand, commandName));
        }

        ConstructorInfo ctor = com.GetConstructors().First();
        ParameterInfo[] parameterInfos = ctor.GetParameters();

        object[] parameters = new object[parameterInfos.Length];

        for (int i = 0; i < parameterInfos.Length; i++)
        {
            Type paramType = parameterInfos[i].ParameterType;

            if (paramType == typeof(IList<string>))
            {
                parameters[i] = args.Skip(1).ToList();
            }
            
            else if (paramType == typeof(IHarvesterController))
            {
                parameters[i] = this.HarvesterController;
            }

            else if (paramType == typeof(IProviderController))
            {
                parameters[i] = this.ProviderController;
            }
        }

        ICommand instance = (ICommand)Activator.CreateInstance(com, parameters);

        return instance;
    }
}

