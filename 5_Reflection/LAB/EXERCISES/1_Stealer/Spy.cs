using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _1_Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, params string[] fieldsToInvestigate)
        {
            Type type = Type.GetType($"_1_Stealer.{classToInvestigate}");

            var instance = Activator.CreateInstance(type, new object[] { });

            var sb = new StringBuilder($"Class under investigation: {classToInvestigate}" + Environment.NewLine);

            var fields = type
                .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

            foreach (var x in fields)
            {

                if (fieldsToInvestigate.Contains(x.Name))
                {
                    sb.AppendLine($"{x.Name} = {x.GetValue(instance)}");
                }
            }

            return sb.ToString().Trim();
        }
    }
}

