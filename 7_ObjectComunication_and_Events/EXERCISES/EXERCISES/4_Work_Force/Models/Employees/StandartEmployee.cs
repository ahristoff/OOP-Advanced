using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Models.Employees
{
    public class StandartEmployee : Employee
    {
        private const int HoursPerWeek = 40;

        public StandartEmployee(string name)
            : base(name, HoursPerWeek)
        {
        }
    }
}
