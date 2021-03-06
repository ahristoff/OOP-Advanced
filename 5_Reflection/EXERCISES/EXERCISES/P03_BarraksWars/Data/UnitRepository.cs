﻿using System;
using _03BarracksFactory.Contracts;
using System.Collections.Generic;
using System.Text;

namespace _03BarracksFactory.Data
{  
    class UnitRepository : IRepository
    {
        private IDictionary<string, int> amountOfUnits;

        public UnitRepository()
        {
            this.amountOfUnits = new SortedDictionary<string, int>();
        }

        public string Statistics
        {
            get
            {
                StringBuilder statBuilder = new StringBuilder();

                foreach (var x in amountOfUnits)
                {
                    string formatedEntry =
                            string.Format("{0} -> {1}", x.Key, x.Value);
                    statBuilder.AppendLine(formatedEntry);
                }

                return statBuilder.ToString().Trim();
            }
        }

        public void AddUnit(IUnit unit)
        {
            string unitType = unit.GetType().Name;

            if (!this.amountOfUnits.ContainsKey(unitType))
            {
                this.amountOfUnits[unitType] = 0;
            }

            this.amountOfUnits[unitType]++;
        }

        public void RemoveUnit(string unitType)
        {
            if (!this.amountOfUnits.ContainsKey(unitType))
            {
                throw new InvalidOperationException("No such units in repository.");
            }

            if (this.amountOfUnits[unitType] == 0)
            {
                throw new InvalidOperationException("No such units in repository.");
            }

            this.amountOfUnits[unitType]--;
        }
    }
}
