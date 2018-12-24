using DependencyInversion.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Models.Strategies
{
    class SubtractionStrategy : IStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
