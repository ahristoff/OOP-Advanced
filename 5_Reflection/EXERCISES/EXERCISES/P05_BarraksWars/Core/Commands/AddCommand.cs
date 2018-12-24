using _05BarracksFactory.Core.Commands;
using _05BarracksFactory.Contracts;
using _05BarracksFactory.Core;

namespace _05BarracksFactory.Core.Commands
{   
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        protected IRepository Repository
        {
            get { return this.repository; }
            set { this.repository = value; }
        }

        protected IUnitFactory UnitFactory
        {
            get => this.unitFactory;
            private set => this.unitFactory = value;
        }

        public override string Execute()
        {
            string unitType = this.Data[1];
            IUnit unitToAdd = this.UnitFactory.CreateUnit(unitType);

            this.Repository.AddUnit(unitToAdd);
            string output = unitType + " added!";

            return output;
        }
    }
}
