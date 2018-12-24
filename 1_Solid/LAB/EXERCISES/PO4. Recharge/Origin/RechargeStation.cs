using PO4.Recharge.Origin.interfaces;

namespace PO4. Recharge.Origin
{
    public class RechargeStation
    {
        public void Recharge(IRechargeable rechargeable)
        {
            rechargeable.Recharge();
        }
    }
}
