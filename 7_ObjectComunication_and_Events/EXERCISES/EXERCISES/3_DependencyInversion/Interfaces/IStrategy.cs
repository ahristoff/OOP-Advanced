using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Interfaces
{
    public interface IStrategy
    {
        int Calculate(int firstOperand, int secondOperand);
    }
}
