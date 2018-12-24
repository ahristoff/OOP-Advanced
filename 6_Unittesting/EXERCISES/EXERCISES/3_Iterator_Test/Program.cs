namespace _Iterator_Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    

    public class Programm
    {
        public static void Main()
        {
            ExecuteCommands();
        }

        private static void ExecuteCommands()
        {
            var InitializationArgs = Console.ReadLine().Split().Skip(1).ToArray();
            var instance = new ListIterator(InitializationArgs);

            var iteratorMethods = instance.GetType().GetMethods();

            var command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    var parsedMethod = iteratorMethods
                        .FirstOrDefault(m => m.Name == command);

                    if (parsedMethod == null)
                    {
                        Console.WriteLine($"This option {command} does not exists");
                    }

                    Console.WriteLine(parsedMethod.Invoke(instance, new object[] { }));
                }
                catch (TargetInvocationException tie)
                {

                    if (tie.InnerException is InvalidOperationException)
                    {
                        Console.WriteLine(tie.InnerException.Message);
                    }
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
