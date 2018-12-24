using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Medium : Mission
{
    private const string name = "Capturing dangerous criminals";
    private const double enduranceRequiered = 50;
    private const double wearLevelDecrement = 50;

    public Medium(double scoreToComplete)
        : base(scoreToComplete)
    {

    }

    public override string Name => name;

    public override double EnduranceRequired => enduranceRequiered;

    public override double WearLevelDecrement => wearLevelDecrement;
}

