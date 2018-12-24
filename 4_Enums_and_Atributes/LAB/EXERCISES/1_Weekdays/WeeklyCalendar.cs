using System.Collections.Generic;

namespace _1_Weekdays
{
    public class WeeklyCalendar
    {
        public IList<WeeklyEntry> WeeklySchedule { get; }

        public WeeklyCalendar()
        {
            WeeklySchedule = new List<WeeklyEntry>();
        }

        public void AddEntry(string weekday, string notes)
        {
            this.WeeklySchedule.Add(new WeeklyEntry(weekday, notes));
        }
    }
}

