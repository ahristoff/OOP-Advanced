using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee("Ivan");

            var documents1 = new List<string>()
            {
                "qwerty",
                "asddfgh",
                "zxcv"
            };

            Manager manager1 = new Manager("Dragan", documents1);

            var list = new List<Employee>();
            list.Add(manager1);
            list.Add(emp1);

            var dp = new DetailsPrinter(list);
            dp.PrintDetails();
        }
    }
}
