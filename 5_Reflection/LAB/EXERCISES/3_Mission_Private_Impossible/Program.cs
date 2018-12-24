using System;

namespace _3_Mission_Private_Impossible
{
    class Program
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var res = spy.RevealPrivateMethods("Hacker");
            Console.WriteLine(res);
        }
    }
}
