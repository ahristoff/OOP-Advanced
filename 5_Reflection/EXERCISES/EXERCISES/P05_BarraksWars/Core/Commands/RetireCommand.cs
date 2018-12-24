using _05BarracksFactory.Contracts;
using System;

namespace _05BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data, IRepository repository)
            : base(data)
        {
            this.repository = repository;
        }

        protected IRepository Repository
        {
            get { return this.repository; }
            set { this.repository = value; }
        }

        public override string Execute()
        {
            var unitToRemove = this.Data[1];

            try
            {
                this.Repository.RemoveUnit(unitToRemove);
                return $"{unitToRemove} retired!";
            }
            catch (Exception e)
            {
                throw new ArgumentException("No such units in repository.", e);
            }                     
        }
    }
}