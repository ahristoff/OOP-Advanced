using System;

namespace _2_High_Quality_Mistakes
{
    class Program
    {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var res = spy.AnalyzeAcessModifiers("Hacker");
            Console.WriteLine(res);
        }
    }
}
