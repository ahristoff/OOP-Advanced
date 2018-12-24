using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    public class Manager : Employee
    {
        public IReadOnlyCollection<string> Documents { get; }

        public Manager(string name, ICollection<string> documents) 
            : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "---" + string.Join("\n---",this.Documents);
        }
    }
}
