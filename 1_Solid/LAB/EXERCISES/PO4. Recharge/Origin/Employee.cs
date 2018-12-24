using PO4.Recharge.Origin.interfaces;
using System;

namespace PO4. Recharge.Origin
{
    public class Employee : Worker, ISleeper
    {
        public Employee(string id)
            : base(id)
        { }

        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
