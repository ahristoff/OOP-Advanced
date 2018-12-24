using System;
using _05BarracksFactory.Contracts;

namespace _05BarracksFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        
        public IUnit CreateUnit(string unitType)
        {
            var type = Type.GetType($"_05BarracksFactory.Models.Units.{unitType}"); 

            var instance = (IUnit)Activator.CreateInstance(type);

            return instance;
        }      
    }
}
