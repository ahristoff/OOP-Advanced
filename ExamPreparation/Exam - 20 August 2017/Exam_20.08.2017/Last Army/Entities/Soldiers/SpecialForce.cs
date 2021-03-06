﻿using System.Collections.Generic;
using System.Text;


public class SpecialForce : Soldier
{
    private const double overallSkillMultiplier = 3.5;
    private const int regenerateIncrease = 30;

    protected override double OverallSkillMultiplier => overallSkillMultiplier;

    private readonly List<string> weaponsAllowed = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };
    protected override List<string> WeaponsAllowed => weaponsAllowed;
    protected override int RegenerateIncrease => regenerateIncrease;

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}
