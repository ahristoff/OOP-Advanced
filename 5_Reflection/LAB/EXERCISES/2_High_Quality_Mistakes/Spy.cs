using System;
using System.Reflection;
using System.Text;

namespace _2_High_Quality_Mistakes
{
    public class Spy
    {
        public string AnalyzeAcessModifiers(string classToInvestigate)
        {
            var type = Type.GetType(classToInvestigate);
            var classFieds = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            var sb = new StringBuilder();

            foreach (var x in classFieds)
            {
                sb.AppendLine($"{x.Name} must be private");
            }

            var properties = type
                .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            foreach (var x in properties)
            {

                if (x.GetMethod.IsPrivate)
                {
                    sb.AppendLine($"{x.GetMethod.Name} have to be public");
                }
            }

            foreach (var x in properties)
            {

                if (x.SetMethod.IsPublic)
                {
                    sb.AppendLine($"{x.SetMethod.Name} have to be private");
                }
            }

            return sb.ToString().Trim();
        }
    }
}


