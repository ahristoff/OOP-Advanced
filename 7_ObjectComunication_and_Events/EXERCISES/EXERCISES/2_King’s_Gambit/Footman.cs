using System;
using System.Collections.Generic;
using System.Text;

namespace King_s_Gambit
{
    public class Footman : Soldier
    {
        public Footman(string name)
            : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {this.Name} is panicking!");
        }
    }
}
