using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    //private double endurance;

    //public IDictionary<string, IAmmunition> Weapons { get; }

    //protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    //public bool ReadyForMission(IMission mission)
    //{
    //    if (this.Endurance < mission.EnduranceRequired)
    //    {
    //        return false;
    //    }

    //    bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

    //    if (!hasAllEquipment)
    //    {
    //        return false;
    //    }

    //    return this.Weapons.Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    //}

    //private void AmmunitionRevision(double missionWearLevelDecrement)
    //{
    //    IEnumerable<string> keys = this.Weapons.Keys.ToList();
    //    foreach (string weaponName in keys)
    //    {
    //        this.Weapons[weaponName].DecreaseWearLevel(missionWearLevelDecrement);

    //        if (this.Weapons[weaponName].WearLevel <= 0)
    //        {
    //            this.Weapons[weaponName] = null;
    //        }
    //    }
    //}

    //public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);

    private const double MaxEndurance = 100;
    private const int SoldierRegenerateValue = 10;

    public string Name { get; }  //razlichno za vseki chovek

    public int Age { get; }      //razlichno za vseki chovek

    public double Experience { get; private set; }

    private double endurance;

    public double Endurance
    {
        get { return endurance; }
        private set
        {
            if (value > 100)
            {
                value = MaxEndurance;
            }
            endurance = value;
        }
    }

    protected abstract double OverallSkillMultiplier { get; }
    public double OverallSkill => (Age + Experience) * OverallSkillMultiplier;

    protected abstract List<string> WeaponsAllowed { get; }
    public IDictionary<string, IAmmunition> Weapons { get; }

    protected virtual int RegenerateIncrease => SoldierRegenerateValue;


    public Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;
        Weapons = new Dictionary<string, IAmmunition>();

        foreach (var x in WeaponsAllowed)
        {
            Weapons.Add(x, null);
        }
    }


    public void CompleteMission(IMission mission)
    {
        Experience += mission.EnduranceRequired;
        Endurance -= mission.EnduranceRequired;

        foreach (var x in Weapons.Values.Where(w => w != null).ToList())
        {
            x.DecreaseWearLevel(mission.WearLevelDecrement);
            if (x.WearLevel <= 0)
            {
                Weapons[x.Name] = null;
            }
        }
    }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.All(w => w != null);

        if (!hasAllEquipment)
        {
            return false;
        }

        bool hasAllWeaponsPositiveWearLevel = this.Weapons.Values.All(w => w.WearLevel > 0);
        if (!hasAllWeaponsPositiveWearLevel)
        {
            return false;
        }
        return true;
    }

    public void Regenerate()
    {
        Endurance += Age + SoldierRegenerateValue; 
    }


        public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
}