using _04BarracksFactory.Contracts;

namespace P04_BarraksWars.Commands
{  
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            var unit = Data[1];
            this.Repository.RemoveUnit(unit);

            return $"{unit} removed";
        }
    }
}
