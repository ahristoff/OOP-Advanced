using System;
using System.Linq;
using System.Reflection;

namespace P02_BlackBoxInteger
{
    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            Type type = typeof(BlackBoxInteger);
            var instance = (BlackBoxInteger)Activator.CreateInstance(type, true);
            var methods = type.GetMethods(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            while (input != "END")
            {
                var com = input.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
                var methodName = com[0];
                var value = int.Parse(com[1]);

                var method = methods.First(n => n.Name == methodName)
                    .Invoke(instance, new object[] { value });

                var field = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).First();

                Console.WriteLine(field.GetValue(instance));
               
                input = Console.ReadLine();
            }
        }
    }
}
