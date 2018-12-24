using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Models.Employees
{
    public abstract class Employee
    {
        public Employee(string name, int workHoursPerWeek)
        {
            this.Name = name;
            this.WorkHoursPerWeek = workHoursPerWeek;
        }

        public string Name { get; protected set; }

        public int WorkHoursPerWeek { get; protected set; }
    }
}
