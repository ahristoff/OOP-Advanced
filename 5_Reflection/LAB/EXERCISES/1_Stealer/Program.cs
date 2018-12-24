using System;

namespace _1_Stealer
{
    class Program
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var res = spy.StealFieldInfo("Hacker", "username", "password");
            Console.WriteLine(res);
        }
    }
}
