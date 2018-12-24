
public interface IWareHouse
{
    void EquipArmy(IArmy army);
    void AddAmunition(string ammunition, int quantity);
    bool TryEquipSoldier(ISoldier soldier);
}

