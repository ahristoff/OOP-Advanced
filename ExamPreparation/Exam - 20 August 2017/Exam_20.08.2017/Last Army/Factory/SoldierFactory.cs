using System;
using System.Linq;
using System.Reflection;

public class SoldierFactory : ISoldierFactory
{
    public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
    {
        Assembly type = Assembly.GetCallingAssembly();
        var model = type.GetTypes().FirstOrDefault(m => m.Name == soldierTypeName);

        return (ISoldier)Activator.CreateInstance(model, name, age, experience, endurance);
    }
}
