using PO4.Recharge.AdapterPattern.interfaces;
using System;

namespace PO4. Recharge.AdapterPattern
{
    public abstract class Worker: ISleeper, IWork, IRechargeable
    {
        public void Recharge()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
