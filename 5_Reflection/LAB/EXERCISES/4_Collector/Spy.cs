using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _4_Collector
{
    public class Spy
    {
        public string CollectGettersAndSetters(string classToInvestigate)
        {
            var type = Type.GetType(classToInvestigate);

            var methods = type
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            var properties = type
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var x in properties)
            {

                if (x.GetMethod != null)
                {
                    sb.AppendLine($"{x.GetMethod.Name} will return {x.GetMethod.ReturnType}");
                }
            }

            foreach (var x in properties)
            {

                if (x.SetMethod != null)
                {
                    sb.AppendLine($"{x.SetMethod.Name} will set field of {x.SetMethod.GetParameters().First().ParameterType}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}


