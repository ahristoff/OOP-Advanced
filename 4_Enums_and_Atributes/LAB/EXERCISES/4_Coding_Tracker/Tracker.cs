using System;
using System.Linq;
using System.Reflection;

namespace _4_Coding_Tracker
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            var type = typeof(Program);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (var x in methods)
            {

                if (x.CustomAttributes.Any(a => a.AttributeType == typeof(SoftUniAttribute)))
                {
                    var autors = x.GetCustomAttributes();

                    foreach (SoftUniAttribute y in autors)
                    {
                        Console.WriteLine($"{x.Name} is writted by {y.Name}");
                    }
                }
            }
        }
    }
}

