﻿using System;
using System.Collections.Generic;
using System.Text;

namespace King_s_Gambit
{
    public class RoyalGuard : Soldier
    {
        public RoyalGuard(string name)
            : base(name)
        {
        }

        public override void KingUnderAttack(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {this.Name} is defending!");
        }
    }
}
