using _05BarracksFactory.Contracts;

namespace _05BarracksFactory.Core.Commands
{
    public abstract class Command : IExecutable  
    {
        private string[] data;
        //private IRepository repository;
        //private IUnitFactory unitFactory;

        protected Command(string[] data)
        {
            this.Data = data;
        }

        protected string[] Data
        {
            get => this.data;
            private set => this.data = value;
        }

        public abstract string Execute();
    }
}
