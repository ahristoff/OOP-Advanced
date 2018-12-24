using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WareHouse : IWareHouse
{
    private Dictionary<string, int> amunitionsQuantities;
    private IAmmunitionFactory ammunitionFactory;

    public WareHouse()
    {
        amunitionsQuantities = new Dictionary<string, int>();
        ammunitionFactory = new AmmunitionFactory();
    }
    public void AddAmunition(string ammunition, int quantity)
    {
        if (!this.amunitionsQuantities.ContainsKey(ammunition))
        {
            this.amunitionsQuantities[ammunition] = 0;
        }

        this.amunitionsQuantities[ammunition] += quantity;
    }

    public bool TryEquipSoldier(ISoldier soldier)
    {
        var wornOutWeapons = soldier.Weapons.Where(w => w.Value == null).Select(w => w.Key).ToList();
        bool isEquipped = true;
        foreach (var x in wornOutWeapons)
        {
            if (amunitionsQuantities.ContainsKey(x) && amunitionsQuantities[x] > 0)
            {
                soldier.Weapons[x] = ammunitionFactory.CreateAmmunition(x);
                amunitionsQuantities[x]--;
            }
            else
            {
                isEquipped = false;
            }
        }

        return isEquipped;
    }

    public void EquipArmy(IArmy army)
    {
        foreach (var x in army.Soldiers)
        {
            TryEquipSoldier(x);
        }
    }

    
   
}

