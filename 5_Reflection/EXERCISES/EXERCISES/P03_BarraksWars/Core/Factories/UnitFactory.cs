using System;
using _03BarracksFactory.Contracts;
using System.Reflection;
using System.Linq;

namespace _03BarracksFactory.Core.Factories
{
    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //TODO : implement for Problem 3

            Assembly assembly = Assembly.GetExecutingAssembly();
            var model = assembly.GetTypes() 
                .FirstOrDefault(n => n.Name == unitType);

            if (model == null)
            {
                throw new ArgumentException("Invalid Unit Type");
            }

            if (!typeof(IUnit).IsAssignableFrom(model)) 
            {
                throw new ArgumentException($"{unitType} is not a unit type!");
            }         

            IUnit instance = (IUnit)Activator.CreateInstance(model);

            return instance;
        }
    }
}
