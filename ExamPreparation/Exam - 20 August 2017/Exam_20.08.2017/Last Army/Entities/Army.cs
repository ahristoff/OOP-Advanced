using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Army : IArmy
{
   

    public IReadOnlyList<ISoldier> Soldiers => soldiers;
    private List<ISoldier> soldiers;
    public Army()
    {
        soldiers = new List<ISoldier>();
    }

    public void AddSoldier(ISoldier soldier)
    {
        soldiers.Add(soldier);
    }

    public void RegenerateTeam(string soldierType)
    {
        foreach (var x in soldiers.Where(s => s.GetType().Name == soldierType))
        {
            x.Regenerate();
        }
    }
}

