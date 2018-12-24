using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Models
{
    public class JobEventArgs : EventArgs
    {
        public JobEventArgs(Job job)
        {
            this.Job = job;
        }

        public Job Job { get; set; }
    }
}
