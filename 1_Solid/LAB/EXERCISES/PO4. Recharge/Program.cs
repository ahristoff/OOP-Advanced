using PO4.Recharge;
using PO4.Recharge.Origin;

namespace PO4._Recharge
{
    class Program
    {
        public static void Main()
        {
            var robot = new Robot("Refactored Robot", 100);
            robot.Work(24);
            robot.Recharge();

            var employee = new Employee("Refactored employee");
            employee.Work(8);
            employee.Sleep();

            var rechargeStation = new RechargeStation();
            rechargeStation.Recharge(robot);
        }
    }
}
