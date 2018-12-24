using System;
using System.Reflection;
using System.Text;

namespace _3_Mission_Private_Impossible
{
    public class Spy
    {
        public string RevealPrivateMethods(string classToInvestigate)
        {
            var type = Type.GetType(classToInvestigate);

            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            var sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {classToInvestigate}");
            sb.AppendLine($"Base Class: {type.BaseType.Name}");

            foreach (var x in methods)
            {
                sb.AppendLine(x.Name);
            }

            return sb.ToString().Trim();
        }
    }
}


