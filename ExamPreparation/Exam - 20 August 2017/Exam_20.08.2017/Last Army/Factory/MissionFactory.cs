using System;
using System.Linq;
using System.Reflection;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        Assembly type = Assembly.GetCallingAssembly();

        var mission = type.GetTypes().FirstOrDefault(m => m.Name == difficultyLevel);

        var instance = (IMission)Activator.CreateInstance(mission, new object[] { neededPoints });

        return instance;
    }
}

