using System;

namespace _4_Collector
{
    class Program
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var res = spy.CollectGettersAndSetters("Hacker");
            Console.WriteLine(res);
        }
    }
}
