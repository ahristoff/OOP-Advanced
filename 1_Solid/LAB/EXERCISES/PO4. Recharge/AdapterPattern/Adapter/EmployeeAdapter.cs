
namespace PO4. Recharge.AdapterPattern.Adapter
{
    public class EmployeeAdapter: Employee
    {
        private Employee employee;

        public void Works()
        {
            employee.Work();
        }

        public void Sleeps()
        {
            employee.Sleep();
        }
    }
}
