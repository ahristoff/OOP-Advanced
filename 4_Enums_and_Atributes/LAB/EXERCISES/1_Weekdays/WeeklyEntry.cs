using System;

namespace _1_Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {

        public WeeklyEntry(string weekday, string notes)
        {
            WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), weekday);
            Notes = notes;
        }

        public WeekDay WeekDay { get; }
        public string Notes { get; }

        public int CompareTo(WeeklyEntry other)
        {

            if (this.WeekDay != other.WeekDay)
            {
                return this.WeekDay.CompareTo(other.WeekDay);
            }

            if (this.Notes != other.Notes)
            {
                return this.Notes.CompareTo(other.Notes);
            }

            return 0;
        }

        public override string ToString()
        {
            return $"{this.WeekDay} - {this.Notes}";
        }
    }
}

