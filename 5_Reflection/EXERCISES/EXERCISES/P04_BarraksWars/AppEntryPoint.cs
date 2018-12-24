using _04BarracksFactory.Contracts;
using _04BarracksFactory.Core;
using _04BarracksFactory.Core.Factories;
using _04BarracksFactory.Data;

namespace _04BarracksFactory
{
    class AppEntryPoint
    {
        static void Main(string[] args)
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();

            ICommandInterpreter commandInterpreter = new CommandInterpreter(repository, unitFactory);

            IRunnable engine = new Engine(repository, unitFactory, commandInterpreter);
            engine.Run();
        }
    }
}
