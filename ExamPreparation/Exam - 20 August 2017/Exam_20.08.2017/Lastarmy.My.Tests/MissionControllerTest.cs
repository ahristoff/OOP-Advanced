using NUnit.Framework;
using System;


public class MissionControllerTest
{
    [Test]
    public void MissionControllerDisplaysFailMessage()
    {
        var army = new Army();
        var wareHouse = new WareHouse();
        var missionController = new MissionController(army, wareHouse);

        var mission = new Easy(100);

        string res = "";

        for (int i = 0; i < 4; i++)
        {
            res = missionController.PerformMission(mission);
        }

        Assert.IsTrue(res.StartsWith("Mission declined - Suppression of civil"));
    }

    [Test]
    public void MissionControllerDisplaysSuccessMessage()
    {
        var army = new Army();
        var wareHouse = new WareHouse();
        var missionController = new MissionController(army, wareHouse);

        var mission = new Easy(0);

        var res = missionController.PerformMission(mission);

        Assert.IsTrue(res.StartsWith("Mission completed - Suppression of civil"));
    }
}
