﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Hard : Mission
{
    private const string name = "Disposal of terrorists";
    private const double enduranceRequiered = 80;
    private const double wearLevelDecrement = 70;

    public Hard(double scoreToComplete)
        : base(scoreToComplete)
    {

    }

    public override string Name => name;

    public override double EnduranceRequired => enduranceRequiered;

    public override double WearLevelDecrement => wearLevelDecrement;
}

