using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class ProviderFactory : IProviderFactory
{
    public IProvider GenerateProvider(IList<string> args)
    {       
        string type = args[0];
        int id = int.Parse(args[1]);
        double energyOutput = double.Parse(args[2]);

        Assembly typee = Assembly.GetExecutingAssembly();

        var provider = typee.GetTypes().FirstOrDefault(p => p.Name == type + "Provider");

        var instance = (IProvider)Activator.CreateInstance(provider, new object[] { id, energyOutput });

        return instance;
    }
}