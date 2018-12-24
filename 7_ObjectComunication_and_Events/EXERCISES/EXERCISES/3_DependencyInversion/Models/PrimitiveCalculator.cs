using DependencyInversion.Interfaces;
using DependencyInversion.Models.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.Models
{
    class PrimitiveCalculator
    {
        private IStrategy strategy;

        public PrimitiveCalculator()
        {
            this.strategy = new AdditionStrategy();
        }

        public void ChangeStrategy(char x)
        {
            switch (x)
            {
                case '+': this.strategy = new AdditionStrategy(); break;
                case '-': this.strategy = new SubtractionStrategy(); break;
                case '*': this.strategy = new MultiplyStrategy(); break;
                case '/': this.strategy = new DivideStrategy(); break;
            }
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return this.strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
