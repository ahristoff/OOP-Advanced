﻿using _05BarracksFactory.Contracts;

namespace _05BarracksFactory.Core.Commands
{
    public class ReportCommand : Command
    {
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data, IRepository repository)
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
            string output = this.Repository.Statistics;
            return output;
        }
    }
}