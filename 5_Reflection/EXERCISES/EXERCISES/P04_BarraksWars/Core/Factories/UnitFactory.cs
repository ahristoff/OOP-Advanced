using System;    
using _04BarracksFactory.Contracts;

namespace _04BarracksFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {        
        public IUnit CreateUnit(string unitType)
        {           
            var type = Type.GetType($"_04BarracksFactory.Models.Units.{unitType}");

            var instance = (IUnit)Activator.CreateInstance(type);

            return instance;
        }      
    }
}
