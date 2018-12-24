using System;
using System.Reflection;
using System.Linq;

public class AmmunitionFactory: IAmmunitionFactory
{
    public IAmmunition CreateAmmunition(string name)
    {
        Assembly type = Assembly.GetCallingAssembly();
        var model = type.GetTypes().FirstOrDefault(m => m.Name == name);

        return (IAmmunition)Activator.CreateInstance(model);
    }
}
