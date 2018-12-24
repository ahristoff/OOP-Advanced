using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Corporal: Soldier
{
    private const double overallSkillMultiplier = 2.5;
    

    protected override double OverallSkillMultiplier => overallSkillMultiplier;

    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",            
            "Helmet",
            "Knife",           
        };
    protected override List<string> WeaponsAllowed => weaponsAllowed;
    

    public Corporal(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}

