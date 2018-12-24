
namespace PO4. Recharge.AdapterPattern.Adapter
{
    public class RobotAdapter:Robot
    {
        private Robot robot;

        public void Works()
        {
            robot.Work();
        }
        public void Recharges()
        {
            robot.Recharge();
        }
    }
}
