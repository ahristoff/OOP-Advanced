using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

public class Class1
{
    private IProviderController providerController;
    private IEnergyRepository energyRepository;
    [Test]
    public void SameName()
    {
        Assert.Pass();
    }

    [Test]
    public void ProducesCorrectAmountOfEnergy()
    {
        this.energyRepository = new EnergyRepository();
        this.providerController = new ProviderController(energyRepository);

        List<string> provider1 = new List<string>()
       {
           "Solar",
           "1",
           "100"
       };

        List<string> provider2 = new List<string>()
       {
           "Solar",
           "2",
           "100"
       };

        providerController.Register(provider1);
        providerController.Register(provider2);


        this.providerController.Produce();

        Assert.AreEqual(200, providerController.TotalEnergyProduced);
    }

    [Test]
    public void CorrectCountEntities()
    {
        this.energyRepository = new EnergyRepository();
        this.providerController = new ProviderController(energyRepository);

        List<string> provider1 = new List<string>()
       {
           "Pressure",
           "1",
           "100"
       };

        providerController.Register(provider1);


        for (int i = 0; i < 8; i++)
        {
            providerController.Produce();
        }

        Assert.AreEqual(0, providerController.Entities.Count);
    }


    //[Test]
    //public void CorrectRepaire()  // ne stava
    //{
    //    this.energyRepository = new EnergyRepository();
    //    this.providerController = new ProviderController(energyRepository);

    //    List<string> provider1 = new List<string>()
    //   {
    //       "Solar",
    //       "1",
    //       "100"
    //   };

    //    providerController.Register(provider1);

    //    providerController.Repair(100);

    //    Assert.AreEqual(1600, providerController.Entities.First().Durability);
    //}

}

