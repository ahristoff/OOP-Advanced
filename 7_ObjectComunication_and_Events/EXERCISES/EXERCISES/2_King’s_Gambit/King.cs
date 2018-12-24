using System;
using System.Collections.Generic;
using System.Text;

namespace King_s_Gambit
{
    public class King
    {
        public event EventHandler UnderAttack;

        public King(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public void OnAttack()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            if (UnderAttack != null)
            {
                UnderAttack(this, null);
            }
        }
    }
}
