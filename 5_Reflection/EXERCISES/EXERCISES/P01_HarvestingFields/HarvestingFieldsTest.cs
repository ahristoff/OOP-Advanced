using System;
using System.Reflection;
using System.Text;

namespace P01_HarvestingFields
{
    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var type = Type.GetType("P01_HarvestingFields.HarvestingFields");
            HarvestingFields instance = (HarvestingFields)Activator.CreateInstance(type);
            var fields = type
                .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            var sb = new StringBuilder();
           
            while (input != "HARVEST")
            {

                if (input == "private")
                {

                    foreach (var x in fields)
                    {

                        if (x.IsPrivate)
                        {                            
                            sb.AppendLine($"{x.Attributes.ToString().ToLower()} {x.FieldType.Name} {x.Name}");
                        }
                    }
                }

                else if (input == "protected")
                {

                    foreach (var x in fields)
                    {

                        if (x.IsFamily)
                        {
                            sb.AppendLine($"protected {x.FieldType.Name} {x.Name}");
                        }
                    }
                }

                else if (input == "public")
                {

                    foreach (var x in fields)
                    {

                        if (x.IsPublic)
                        {
                            sb.AppendLine($"{x.Attributes.ToString().ToLower()} {x.FieldType.Name} {x.Name}");
                        }
                    }
                }

                else if (input == "all")
                {

                    foreach (var x in fields)
                    {                     
                        sb.AppendLine($"{x.Attributes.ToString().ToLower()} {x.FieldType.Name} {x.Name}");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString().Replace("family", "protected").Trim());
        }
    }
}
