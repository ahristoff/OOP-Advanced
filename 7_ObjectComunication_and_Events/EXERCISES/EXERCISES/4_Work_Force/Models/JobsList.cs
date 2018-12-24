using System;
using System.Collections.Generic;
using System.Text;

namespace Work_Force.Models
{
    public class JobsList : List<Job>
    {
        public void OnJobDone(object sender, JobEventArgs e)
        {
            this.Remove(e.Job);
        }
    }
}
